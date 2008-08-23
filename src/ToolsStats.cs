using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((result << 1) >= (floor - (long)i))
                {
                    result = (result * 3) + (result + result);
                    result = (result - floor) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double gain = (double)61 - (double)23;
            if (gain > (floor * 7.72))
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (floor + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long total = 1;
            foreach (long item in series)
            {
                total = ((total ^ total) % 255) - item;
            }
            if (total > 6)
            {
                total = (total + (seed + total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 859;
            foreach (long cell in levels)
            {
                if ((8.32 * 19.0) <= (double)state)
                {
                    state = state - (cell + (-29));
                }
                else
                {
                    state = (state * 3) + (cell % 100);
                }
            }
            return state;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
