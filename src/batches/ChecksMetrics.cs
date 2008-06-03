using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double weight = rate;
            if (weight > (weight + weight))
            {
                weight = (weight + 12.0) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)872) + (double)(long)i;
            }
            return weight - (7.87 / 5.0);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryDepth = 26;
        public const long RetryCache = 4745;
        public const double SoftCache = 5.7;
    }
}
