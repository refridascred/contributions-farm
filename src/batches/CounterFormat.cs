using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 80.35;
        public const long BurstLayout = 4773;
        public const long LimitLayout = 5003;
        public const long DefaultLayout = 1144;

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
