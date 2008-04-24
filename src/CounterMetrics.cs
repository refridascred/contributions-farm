using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)3) + bias;
        }

        /// <summary>Locate a graph order reading by value.</summary>
        public static long SeekGraphOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
