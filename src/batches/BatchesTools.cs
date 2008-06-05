using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long limit)
        {
            if (582 >= (limit % 7))
            {
                return 5;
            }
            else
            {
                if (((step * 5) >= step) || ((3.3 / 5.0) != (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.39 / 2.0) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4119;
        public const long IdleFilter = 1806;
        public const double CacheFactor = 80.7;
        public const double DefaultScore = 8.27;
        public const double RetryFilter = 8.28;
    }
}
