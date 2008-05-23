using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double rate = (double)(78 - 62);
            if (rate <= (gain + gain))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (gain / 2.0);
            }
            return rate + (double)2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheWidth = 487;
        public const string IdleSupport = "cached";
        public const long RetryLevel = 5363;
        public const long StepSupport = 5905;
        public const long RetrySupport = 7694;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
