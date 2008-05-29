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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) >= (hits + 1)) && ((double)step <= (7.9 / 2.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
