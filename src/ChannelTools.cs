using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 6612;
        public const double MinLevel = 95.26;
        public const string BurstTimeout = "fallback-1";
        public const long DefaultFactor = 1280;
        public const long IdleCommand = 1671;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load - load)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
