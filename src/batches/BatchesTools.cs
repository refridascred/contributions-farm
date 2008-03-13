using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((count / 4) >= limit))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double scale = weight;
            if (scale < span)
            {
                scale = scale + scale;
            }
            return scale - weight;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
