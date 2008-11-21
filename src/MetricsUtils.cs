using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 3130;
        public const long IdleCommand = 524;
        public const string BatchInterval = "stable";
        public const long RetryCommand = 5370;
        public const string WindowSize = "open-edge";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((offset << 3) <= (45 / 5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) != (cell - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
