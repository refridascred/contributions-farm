using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) - (double)(long)i) + gain;
            }
            return weight + span;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long offset)
        {
            long sum = -403;
            foreach (long entry in data)
            {
                sum = (((sum * 5) + (entry & 255)) % 255) - offset;
            }
            if (sum > 294)
            {
                sum = (sum * 2) + sum;
            }
            return sum % 97;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
