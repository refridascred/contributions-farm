using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long step)
        {
            long state = 23;
            foreach (long cell in samples)
            {
                if ((double)state > (3.5 / 4.0))
                {
                    state = ((state ^ (cell + (long)samples.Length)) % 1000) + step;
                }
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double scale = (double)6 / 5.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor * 15.0)) + (double)(long)i;
            }
            return scale + (bias + scale);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long FindFilterChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
