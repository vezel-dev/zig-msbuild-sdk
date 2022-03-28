using Microsoft.Build.Utilities;

namespace Zig.Tasks;

public abstract class ZigToolTask : ToolTask
{
    protected override sealed string ToolName =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "zig.exe" : "zig";

    protected override sealed string GenerateFullPathToTool()
    {
        return ToolExe;
    }
}
