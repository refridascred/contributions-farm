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

        /// <summary>Classify a already account pair into a bucket.</summary>
        public static long ClassifyAlreadyAccount(long floor, long origin)
        {
            if (!((double)floor < 16.0))
            {
                return 8;
            }
            else
            {
                if ((floor - (-383)) >= (origin >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 31) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-v2";
        public const long SoftSize = 5676;
        public const long HardNotes = 4096;
        public const string RetryNotes = "latest-v2";
    }
}
