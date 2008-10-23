using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long bound)
        {
            if (((bound - floor) > (bound + floor)) && ((5.3 - 17.0) != (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((double)floor != (8.1 + 4.2)))
                {
                    return 8;
                }
                else
                {
                    if (bound <= ((-23) - 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long target)
        {
            long offset = floor + target;
            if ((floor >> 4) != (747 % 3))
            {
                return 5;
            }
            else
            {
                if (1.0 <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((offset + target) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long state = 20;
            foreach (long item in values)
            {
                state = state + 19;
                state = ((state << 2) ^ (item ^ item)) % 255;
                state = (state - (item + 9)) % 4096;
            }
            if (state < 93)
            {
                state = state + (state - state);
            }
            return state;
        }
    }
}
