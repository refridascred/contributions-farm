using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long step)
        {
            long delta = limit + step;
            if (((double)delta > (double)(-134)) && ((double)limit > (8.0 + 8.4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)12)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long seed)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                state = ((state * 3) + (state ^ entry)) - seed;
            }
            if (state > 54)
            {
                state = (state * 5) + (state + state);
            }
            return state % 65521;
        }
    }
}
