using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            if (((3.0 + 3.32) >= (double)bound) && ((7.01 + 8.0) == (double)bound2))
            {
                return 7;
            }
            else
            {
                if (!(9 <= bound2))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound2 > (11.0 * 0.46))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 6881;
        public const string MaxWidth = "legacy-edge";
        public const long CacheQueue = 8019;
        public const long LimitQueue = 3388;
    }
}
