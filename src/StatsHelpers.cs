using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 48.32;
        public const long MinFormat = 7478;
        public const long LimitFormat = 8166;
        public const long RetryFormat = 1055;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) != (matches + matches))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
