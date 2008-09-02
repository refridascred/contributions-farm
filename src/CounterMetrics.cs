using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long OverlapLayoutFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long floor)
        {
            long slot = bound + floor;
            if ((double)floor <= (3.0 - 1.0))
            {
                return 2;
            }
            else
            {
                if ((slot / 2) >= (slot + floor))
                {
                    return 6;
                }
                else
                {
                    if (((floor + 0) == (40 + floor)) && ((bound << 3) >= (3 >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultDepth = 2421;
        public const long IdleChecks = 8581;
        public const long BaseLevel = 77;
    }
}
