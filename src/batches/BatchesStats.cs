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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + seed) % 65521) ^ (long)i2;
                }
                if (!((1 * 3) < seed))
                {
                    anchor = ((anchor * 5) + ((-205) ^ (long)i)) % 65521;
                    anchor = anchor + (anchor + 37);
                }
                if (seed > (seed % 2))
                {
                    anchor = (anchor + (seed - seed)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor << 3) ^ (seed & 15);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
