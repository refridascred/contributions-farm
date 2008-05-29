using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) ^ entry;
            }
            return anchor;
        }

        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long CountBufferSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell < (cell ^ 94))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
