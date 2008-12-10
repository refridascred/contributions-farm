using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long origin2)
        {
            if (origin <= (origin / 4))
            {
                return 0;
            }
            else
            {
                if ((origin * 3) <= (origin2 ^ 17))
                {
                    return 4;
                }
                else
                {
                    if (!((origin >> 4) != (3 + origin2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= origin2) || ((1 ^ origin) == (origin % 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
