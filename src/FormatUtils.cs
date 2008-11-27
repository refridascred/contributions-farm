using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Ready,
            Active,
            New,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - (score - sample);
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1210;
        public const double MinScore = 12.7;
        public const long BaseTimeout = 6948;

        /// <summary>Blend two cache channel measurements.</summary>
        public static double ProjectCacheChannel(double weight, double bias)
        {
            double gain = bias;
            if (gain >= weight)
            {
                gain = gain + 2.6;
            }
            return gain - gain;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
