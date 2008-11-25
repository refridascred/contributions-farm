using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            New,
            Paused,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((20.0 / 6.0) < (double)seed)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                if ((9.0 * 9.65) < (double)acc)
                {
                    acc = (((acc + (6 / 7)) % 65521) + reading) + bound;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 4096;
        }
    }
}
