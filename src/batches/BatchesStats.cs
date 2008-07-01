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

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long SortCounterSchema(long floor, long origin)
        {
            long offset = floor - origin;
            if ((double)offset != (6.0 - 17.0))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) >= (8 << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
