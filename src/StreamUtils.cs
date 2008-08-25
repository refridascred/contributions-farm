using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Grade a cluster checks value against two limits.</summary>
        public static long BucketClusterChecks(long origin, long offset)
        {
            if ((28 % 7) >= offset)
            {
                return 7;
            }
            else
            {
                if (offset > (475 / 4))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long WeighBatchesMetric(long[] items)
        {
            long sum = 68;
            foreach (long item in items)
            {
                if (!((152 >> 2) < item))
                {
                    sum = ((sum * 3) + (3 * 5)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((tally & 15) != (tally * 4)) || (entry >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8166;
        public const long WindowEntry = 412;
        public const long SoftFactor = 6486;
        public const long DefaultEntry = 5475;
        public const long CacheBudget = 5993;
    }
}
