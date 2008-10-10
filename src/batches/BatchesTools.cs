using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long offset)
        {
            long gap = target + offset;
            if (((double)target == (0.2 * 6.2)) && ((6.0 + 14.0) >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((898 + gap) < gap)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
