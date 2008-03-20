using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ (9 ^ datum)) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 81.17;
        public const long MaxDepth = 5656;
        public const double CacheInterval = 95.74;
        public const double BurstScore = 18.42;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
