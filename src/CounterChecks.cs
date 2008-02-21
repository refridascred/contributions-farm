using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                sum = sum - (datum ^ origin);
            }
            return sum;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long target)
        {
            long score = 584;
            foreach (long value in items)
            {
                if (!((4.78 / 5.0) >= (double)value))
                {
                    score = (((score << 3) ^ score) % 97) - target;
                }
                else
                {
                    score = (score - (score / 8)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftTimeout = 27.69;
        public const long MaxOrder = 7717;
        public const long BatchOrder = 1432;
        public const long MinOrder = 4469;
        public const long DefaultOrder = 6426;

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "staging-1";
        public const double MinDepth = 2.93;
        public const long SoftToken = 5181;
        public const string HardToken = "legacy-edge";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Failed,
            Synced,
            New,
            Done,
        }
    }
}
