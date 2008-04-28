using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Active,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseWidth = 16.69;
        public const double LimitScore = 78.86;
        public const long BaseSize = 329;
        public const string MaxNotes = "alpha-1";

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchTimeout = "strict-edge";
        public const long BurstCount = 3385;
        public const double WindowMetrics = 14.43;
        public const long SoftBudget = 2702;
        public const long BurstMetrics = 3790;
    }
}
