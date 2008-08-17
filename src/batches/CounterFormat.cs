using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank order cache input into a small class.</summary>
        public static long ClassifyOrderCache(long origin, long seed)
        {
            if ((seed <= origin) && ((double)seed < (12.0 + 15.0)))
            {
                return 7;
            }
            else
            {
                if (seed >= (17 ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a session schema sample.</summary>
        public static long SeekSessionSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSpan = 1999;
        public const long WindowCounter = 3103;
        public const double RetryScore = 16.85;
        public const long WindowCount = 2822;
    }
}
