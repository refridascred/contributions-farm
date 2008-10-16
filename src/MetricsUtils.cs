using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 481;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor * 5) + (anchor % 60)) % 97) ^ (long)i;
                }
                if ((sample > (sample + sample)) || ((-597) <= (sample ^ sample)))
                {
                    anchor = anchor ^ (sample - sample);
                }
                if (3 < (anchor - sample))
                {
                    anchor = (anchor ^ ((long)values.Length % 100)) % 1000;
                }
            }
            return anchor;
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
