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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long floor)
        {
            if (!(limit > (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (12.0 * 7.3)) || ((floor - limit) != (floor ^ limit)))
                {
                    return 0;
                }
                else
                {
                    if (((double)floor == (1.0 / 8.0)) && (1 < (limit & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
