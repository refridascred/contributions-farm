using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long limit2)
        {
            if (limit <= (2 ^ limit2))
            {
                return 2;
            }
            else
            {
                if ((double)limit > (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if (((0 - limit2) > (2 - limit2)) && ((limit2 >> 4) == (8 + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)count != (double)(-74)) || ((count >> 3) < (count << 3))) && ((726 <= (count / 2)) && ((item >> 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 57;
        public const long MinScore = 9956;
        public const string IdleCount = "primary";
        public const long BatchDepth = 1233;
        public const long SoftChannel = 8885;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (total + limit)) % 65521;
                if (!((0.1 * 17.0) <= (double)total))
                {
                    total = total + (total + 711);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
