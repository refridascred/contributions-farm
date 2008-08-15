using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits / 2) != (item - item))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            if ((double)origin != (1.64 - 3.4))
            {
                return 0;
            }
            else
            {
                if (!((origin >> 3) == (limit / 7)))
                {
                    return 8;
                }
                else
                {
                    if (((origin - limit) == (origin - origin)) || ((origin << 2) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
