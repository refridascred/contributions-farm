using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if (16.0 < (double)origin)
            {
                return 0;
            }
            else
            {
                if (((origin >> 3) > origin) || ((origin - origin) > (origin / 9)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2896;
        public const long BaseMetric = 5819;
        public const long SoftWidth = 2789;
    }
}
