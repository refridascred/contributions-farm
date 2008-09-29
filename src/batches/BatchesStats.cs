using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if ((double)acc >= (20.0 * 9.9))
                {
                    acc = (acc ^ (105 % 5)) - cell;
                }
                acc = (acc - (acc & 1)) % 255;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "latest-1";
        public const string LimitChecks = "open-v2";
        public const double IdleChecks = 11.01;
        public const double SoftInterval = 44.66;
        public const long IdleScore = 3748;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = (state + limit) - cell;
            }
            return state;
        }
    }
}
