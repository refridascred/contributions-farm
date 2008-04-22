using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (5.0 + bias) * 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - bias) + (double)(long)i) - weight;
            }
            return load + (load * 3.0);
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6104;
        public const string CacheFormat = "standard-edge";
        public const double BatchSpan = 73.87;
        public const string MinBudget = "fallback";

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 39.14;
        public const string CacheAlready = "primary-v2";
        public const string CacheWidth = "open-v2";
        public const double BaseAlready = 48.42;
        public const double BurstAlready = 18.45;
    }
}
