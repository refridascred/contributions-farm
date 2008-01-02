using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double BlendQueueMetrics(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (floor / 7.0)) - (double)(long)i) - bias;
            }
            return mean + (mean * 1.03);
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate * 7.0))
            {
                rate2 = rate2 + (rate2 / 8.0);
            }
            return rate2 + (rate2 + rate2);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 4.14;
        public const long DefaultContext = 7441;
        public const long CacheContext = 1223;
        public const long StepScore = 3471;
        public const double DefaultTimeout = 66.13;
    }
}
