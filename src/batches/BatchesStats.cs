using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxLevel = "primary";
        public const long HardSize = 9510;
        public const double SoftCluster = 2.51;
        public const string RetryScore = "open-v2";
        public const long MaxCluster = 8917;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series)
        {
            long mark = 32;
            foreach (long entry in series)
            {
                mark = ((mark - (mark & 1)) % 1000) ^ entry;
            }
            if (mark > 539)
            {
                mark = (mark - (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
