using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long seed, long offset)
        {
            if ((offset + seed) <= offset)
            {
                return 2;
            }
            else
            {
                if (4.04 >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) != (seed * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long TotalCommitsCache(long[] items, long limit)
        {
            long sum = 15;
            foreach (long sample in items)
            {
                sum = ((((sum * 4) + (sum + sum)) % 65521) ^ sample) + limit;
                if ((9.3 + 7.14) == (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (6.7 >= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((item - seen) >= item) || ((5.46 - 5.95) == (double)item)) || ((seen - seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count == (0.9 * 9.8))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
