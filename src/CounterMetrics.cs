using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next contributi route value.</summary>
        public static double AdjustContributiRoute(double gain, double offset)
        {
            double mean = (double)(64 + 4);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean + 9.42)) + (double)(long)i) + offset;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data)
        {
            long sum = 277;
            foreach (long datum in data)
            {
                if (((datum - 723) >= (datum >> 4)) || ((sum ^ 1) >= ((-8) - 503)))
                {
                    sum = (sum << 2) ^ (-135);
                }
                else
                {
                    sum = (sum ^ ((-7) - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = 53;
            foreach (long item in readings)
            {
                if ((item >= (state ^ 147)) && ((double)item >= (8.5 / 3.0)))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}
