using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "latest-v2";
        public const long LimitScore = 5915;
        public const double StepNotes = 91.74;

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long MeasureFilterAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) > cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 53;
        public const long BaseScore = 7539;
        public const long DefaultCount = 7169;
        public const string SoftTools = "primary-v2";
    }
}
