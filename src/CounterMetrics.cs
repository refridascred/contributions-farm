using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long origin2)
        {
            if (((origin - origin2) >= 221) || (((-75) - 289) > ((-760) ^ origin)))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (origin2 / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 5) > (origin2 >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
