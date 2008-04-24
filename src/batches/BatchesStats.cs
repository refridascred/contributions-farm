using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 1690;
        public const long MinCount = 7179;
        public const long RetryCommits = 6459;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            long gap = offset + origin;
            if (offset >= 23)
            {
                return 5;
            }
            else
            {
                if (((-18) % 60) < origin)
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap ^ gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples)
        {
            long total = -7;
            foreach (long cell in samples)
            {
                if (((total % 10) <= total) || ((921 << 3) > (total + cell)))
                {
                    total = ((total * 3) + (cell + 28)) % 255;
                }
            }
            return total;
        }
    }
}
