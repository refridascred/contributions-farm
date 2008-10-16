using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstSize = 13.54;
        public const double LimitGithubfarm = 20.05;
        public const long CacheGithubfarm = 8716;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long bound)
        {
            long result = 276;
            foreach (long datum in readings)
            {
                if ((bound & 63) <= (bound + bound))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
            }
            if (result < 404)
            {
                result = (result << 2) ^ (bound & 1);
            }
            return result;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches > (matches & 7))
                {
                    matches = ((matches + 2) ^ cell) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
