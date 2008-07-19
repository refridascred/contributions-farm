using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitLevel = "local-edge";
        public const double IdleSize = 93.32;
        public const long LimitBuffer = 2443;
        public const long BatchRatio = 7788;
        public const long LimitCount = 6419;

        /// <summary>Find the first schema filter entry that matches the target.</summary>
        public static long SeekSchemaFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
