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

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double weight2 = (double)(6 - 92);
            if (weight2 > (double)70)
            {
                weight2 = (weight2 + (double)3) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (8.52 + 8.56)) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
