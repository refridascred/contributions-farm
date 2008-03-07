using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if ((bound ^ origin) > 673)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.6 - 3.38))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseDepth = 7532;
        public const double SoftTimeout = 71.7;
        public const long LimitBatch = 5510;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) < (reading << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter farm entries.</summary>
        public static long FoldFilterFarm(long[] series, long target)
        {
            long sum = -6;
            foreach (long datum in series)
            {
                sum = (((sum * 2) + (sum % 2)) - datum) + target;
            }
            return sum;
        }
    }
}
