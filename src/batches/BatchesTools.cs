using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long total = -53;
            foreach (long cell in levels)
            {
                if (((cell * 2) <= 249) || ((double)total < (4.22 * 0.5)))
                {
                    total = (total ^ 471) % 101;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 7767;
        public const double IdleLevel = 64.4;
        public const long LimitLevel = 8810;
    }
}
