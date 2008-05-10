using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 57.4;
        public const string SoftWidth = "local";
        public const long BurstChannel = 9512;
        public const long BurstDepth = 9372;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long score = 6;
            foreach (long item in items)
            {
                if (!((0.1 + 5.3) <= (double)score))
                {
                    score = ((score ^ (step + 1)) % 65521) - item;
                }
                else
                {
                    score = score - (403 >> 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
