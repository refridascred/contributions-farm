using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 241;
        public const long CacheBudget = 9591;
        public const string BurstDepth = "legacy";
        public const long SoftFactor = 6733;

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double drift = span;
            if (drift >= (gain / 2.0))
            {
                drift = drift - (drift + span);
            }
            else
            {
                drift = drift - (gain / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetrySpan = 32.1;
        public const long IdleDepth = 4033;
        public const long IdleCache = 4994;
        public const long LimitScore = 1928;
    }
}
