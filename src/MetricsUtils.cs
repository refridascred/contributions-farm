using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 8350;
        public const long CacheWindow = 9349;
        public const string StepBudget = "fallback-edge";
        public const double BurstTimeout = 64.35;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 799;
        public const double HardLevel = 59.25;
        public const string MaxScore = "alpha";
        public const long StepLevel = 9027;
        public const long BaseWidth = 6248;

        /// <summary>Compare every pair of support report readings.</summary>
        public static long MatchSupportReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
