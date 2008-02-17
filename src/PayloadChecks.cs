using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftScore = 3833;
        public const double WindowTimeout = 56.29;
        public const long MaxWidth = 8818;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 14;
            foreach (long datum in samples)
            {
                if (state > datum)
                {
                    state = state + state;
                }
                if (!((double)state < 0.5))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1770;
        public const string BurstSession = "cached-1";
        public const double BurstFactor = 6.87;
        public const long SoftInterval = 5739;
        public const long HardSession = 1304;
    }
}
