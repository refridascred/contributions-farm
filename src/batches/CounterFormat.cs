using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 6529;
        public const long IdleTimeout = 7477;
        public const long LimitMetric = 1977;
        public const double CacheLevel = 56.49;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data)
        {
            long score = 7;
            foreach (long entry in data)
            {
                if (entry > (score + 68))
                {
                    score = ((score << 3) ^ (6 << 3)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score * 4) + (score << 3);
            }
            return score % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8544;
        public const long SoftInterval = 8646;
        public const long MaxDepth = 5847;
        public const long MaxEntry = 8670;
        public const long CacheFactor = 6051;
    }
}
