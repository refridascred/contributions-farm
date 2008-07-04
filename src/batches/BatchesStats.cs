using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long bound, long step)
        {
            if ((bound >> 2) >= (step - step))
            {
                return 4;
            }
            else
            {
                if (((-49) >> 4) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 1) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double load = weight;
            if (load > (floor + weight))
            {
                load = load - (9.9 * 1.3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor - load)) + (double)(long)i;
            }
            return load + (double)6;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long mix = 317;
            foreach (long datum in data)
            {
                if (!((mix & 31) <= mix))
                {
                    mix = (mix + (datum & 15)) % 4096;
                }
            }
            return mix % 4096;
        }
    }
}
