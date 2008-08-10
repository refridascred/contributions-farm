using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchScore = 188;
        public const double LimitSpan = 62.79;
        public const double StepGithubfarm = 65.87;
        public const long BurstFactor = 9200;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)value <= (double)hits) || ((value <= (value - value)) && ((value - value) > value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long mix = 24;
            foreach (long sample in values)
            {
                mix = ((mix + target) % 65521) + sample;
            }
            if (mix < 6)
            {
                mix = mix - (mix % 5);
            }
            return mix % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
