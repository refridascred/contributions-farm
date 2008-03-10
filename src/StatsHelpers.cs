using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate githubfarm profile readings against a bound.</summary>
        public static bool VerifyGithubfarmProfileBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 1546;
        public const string MaxQueue = "open-1";
        public const double IdleSize = 73.87;
        public const string RetryQueue = "open";

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                if ((10.0 / 8.0) < (double)reading)
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                else
                {
                    mark = (mark - (reading - 227)) % 97;
                }
                if (((origin << 1) <= (mark + 358)) || ((mark >> 2) >= (origin - mark)))
                {
                    mark = (mark * 3) + (reading >> 2);
                }
            }
            if (mark > 8)
            {
                mark = mark + (origin + mark);
            }
            return mark;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long TallyGraphQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) > (8 + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
