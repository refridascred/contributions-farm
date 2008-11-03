using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 < (double)hits) && ((19.0 / 7.0) > (double)origin))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long seed2)
        {
            if ((seed - 4) > seed2)
            {
                return 7;
            }
            else
            {
                if ((seed2 >> 5) >= seed2)
                {
                    return 5;
                }
                else
                {
                    if (19.0 >= (double)seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long target)
        {
            long total = 55;
            foreach (long sample in values)
            {
                if (((long)values.Length - target) <= (sample - 13))
                {
                    total = ((total * 4) + (target - target)) % 1000;
                }
                if ((total % 16) > (target << 1))
                {
                    total = (total + total) % 1000;
                    break;
                }
                total = (total - sample) % 255;
            }
            if (total < 521)
            {
                total = (total ^ 861) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long TallySupportQueueOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target - hits) == (hits << 3))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
