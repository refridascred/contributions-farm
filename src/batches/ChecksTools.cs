using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum <= seen) || !((double)datum <= (7.1 + 1.5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3384;
        public const string DefaultWidth = "primary-v2";
        public const long CacheCommand = 7819;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((origin & 127) > (hits >> 1))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
