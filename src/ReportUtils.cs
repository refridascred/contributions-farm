using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 86.3;
        public const double HardBatches = 87.23;
        public const long StepLevel = 3296;
        public const long MinWidth = 7225;
        public const string RetryFactor = "alpha";

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long seed)
        {
            if (((floor & 15) >= floor) && ((5.9 * 15.0) <= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((3.0 * 3.1) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((floor << 3) != (seed - seed)) || (seed > (2 / 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((76 ^ seed) <= (floor % 60)) || ((418 + floor) >= (seed - floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
