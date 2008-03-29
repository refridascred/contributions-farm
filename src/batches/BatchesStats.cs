using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
