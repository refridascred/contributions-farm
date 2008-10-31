using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseDepth = 32.09;
        public const string BurstFilter = "strict-edge";
        public const string DefaultSize = "cached-1";

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long bound, long origin)
        {
            if (origin < ((-612) * 2))
            {
                return 2;
            }
            else
            {
                if (((958 * 4) == (9 - origin)) || ((5.8 + 1.0) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
