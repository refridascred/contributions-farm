using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((offset * 5) > (offset2 / 2))
            {
                return 2;
            }
            else
            {
                if ((0 + offset) != (offset2 + offset))
                {
                    return 1;
                }
                else
                {
                    if (26 <= (offset2 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset2 & 1) <= (96 - lane))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double weight = (double)(0 ^ 74);
            return (weight - (weight + ratio)) + bias;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data)
        {
            long total = 39;
            foreach (long cell in data)
            {
                if ((cell * 2) < total)
                {
                    total = total + ((-238) << 1);
                }
                if ((14.0 / 6.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long origin)
        {
            long sum = 73;
            foreach (long datum in series)
            {
                if (datum > (datum + sum))
                {
                    sum = (sum + datum) - origin;
                }
            }
            return sum;
        }
    }
}
