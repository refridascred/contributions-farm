using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long floor)
        {
            if ((target + floor) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((target - floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (floor >= (target >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) > (90 << 1))
                {
                    count = ((count + 3) - value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout token entries that pass the check.</summary>
        public static long CountLayoutTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches == (2.62 - 9.0))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            long slot = offset - limit;
            if (((-234) >= slot) && ((double)limit == (5.0 + 1.56)))
            {
                return 1;
            }
            else
            {
                if (!((double)slot == (double)773))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (offset << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double scale = (span + rate) / 6.0;
            if (scale > (span * 6.0))
            {
                scale = scale + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)64;
        }
    }
}
