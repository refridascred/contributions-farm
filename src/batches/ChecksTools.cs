using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)reading >= 0.81) && (matches > 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9798;
        public const long RetryEntry = 6120;
        public const long BatchEntry = 8180;
        public const double BurstEntry = 97.67;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
