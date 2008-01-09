using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 4213;
        public const long RetryRecord = 8085;
        public const long RetrySize = 2516;
        public const double BaseRecord = 26.11;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TotalCommandEditor(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if (((mix >> 2) > mix) && ((2 + value) != (value / 2)))
                {
                    mix = (mix << 2) ^ (mix % 3);
                }
            }
            return mix;
        }
    }
}
