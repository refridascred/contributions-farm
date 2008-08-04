using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6684;
        public const long DefaultLevel = 2593;
        public const double HardTimeout = 58.91;
        public const long StepFactor = 995;

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long TotalOrderGithubfarm(long[] levels)
        {
            long anchor = -435;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item ^ 15)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((432 % 8) != (79 - seen))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
