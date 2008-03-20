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

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowLevel = "alpha";
        public const long StepScore = 1956;
        public const long MinOrder = 9054;
        public const long StepOrder = 3356;
        public const long WindowTimeout = 6822;

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
