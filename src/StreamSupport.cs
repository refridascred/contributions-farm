using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double rate2 = (double)(0 >> 4);
            if (rate2 > (offset - rate2))
            {
                rate2 = (rate2 + (offset * 9.0)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9275;
        public const long RetryEntry = 1295;
        public const long CacheBudget = 2214;
        public const string MinInterval = "alpha-v2";
    }
}
