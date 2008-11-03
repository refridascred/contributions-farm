using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 3707;
        public const long WindowProfile = 5716;
        public const double SoftProfile = 31.12;
        public const string RetryProfile = "latest-edge";
    }
}
