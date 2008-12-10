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

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double ratio, double offset)
        {
            double scale = (double)(7 + 86);
            if (scale < (ratio + 5.65))
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (ratio - ratio)) + (double)(long)i;
            }
            return scale - ratio;
        }

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
