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

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 1662;
        public const long BurstLevel = 5510;
        public const double BasePayload = 73.19;
        public const long HardWidth = 3251;
    }
}
