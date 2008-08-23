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

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8140;
        public const long StepTimeout = 7559;
        public const long DefaultScore = 6218;
        public const long MaxScore = 3258;

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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen - floor) == (40 * 4)) || (seen <= (seen ^ 79)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
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
