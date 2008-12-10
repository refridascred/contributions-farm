using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long AuditTokenGithubfarmGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)datum > (9.0 + 4.79)))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1039;
        public const long RetryAlready = 594;
        public const string DefaultTimeout = "alpha-edge";
        public const long BatchSpan = 8306;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long acc = -29;
            foreach (long datum in data)
            {
                acc = (((acc + 1) % 101) ^ datum) - floor;
            }
            return acc % 1000;
        }
    }
}
