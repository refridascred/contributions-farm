using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 24.11;
        public const double LimitProfile = 97.44;
        public const long WindowProfile = 2311;
        public const long WindowWidth = 4867;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Accumulate window tools samples.</summary>
        public static long WeighWindowTools(long[] samples)
        {
            long mark = 39;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark - 762) % 65521) ^ (long)i;
                }
                if ((mark << 1) < (cell * 5))
                {
                    mark = ((mark * 2) + (cell + mark)) % 255;
                }
                if ((2.1 * 2.0) <= (double)mark)
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
