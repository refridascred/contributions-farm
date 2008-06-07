using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstBudget = "cached-v2";
        public const long CacheDepth = 8450;
        public const long IdleTimeout = 7615;
        public const double BaseRatio = 85.46;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate profile editor readings against a bound.</summary>
        public static bool VerifyProfileEditorLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
