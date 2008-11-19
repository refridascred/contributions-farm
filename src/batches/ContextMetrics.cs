using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-v2";
        public const long SoftSize = 5676;
        public const long HardNotes = 4096;
        public const string RetryNotes = "latest-v2";
    }
}
