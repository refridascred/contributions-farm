using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long target)
        {
            long bound = offset + target;
            if ((double)bound >= (2.6 / 7.0))
            {
                return 7;
            }
            else
            {
                if (!((1 << 1) > (target - 227)))
                {
                    return 1;
                }
                else
                {
                    if ((8.75 - 18.0) < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "legacy-v2";
        public const long SoftWindow = 7757;
        public const long MaxWindow = 310;

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long BucketBatchesCache(long bound, long seed)
        {
            long diff = bound - seed;
            if (!((double)diff > (0.3 / 3.0)))
            {
                return 5;
            }
            else
            {
                if (((seed + bound) > (bound ^ bound)) || ((38 >> 2) < (bound & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.0 * 4.29))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((diff * 2) <= (69 + seed)) || ((double)bound > (10.0 * 6.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits >> 5) >= 70)
                {
                    hits = ((hits + 1) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = offset;
            if (mean < (12.0 - weight))
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + 6.97;
        }
    }
}
