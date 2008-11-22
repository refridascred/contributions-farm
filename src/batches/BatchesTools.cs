using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two batch account measurements.</summary>
        public static double SmoothBatchAccount(double weight, double offset)
        {
            double weight2 = 4.55 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + (weight2 - offset);
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Pending,
            New,
            Closed,
        }

        /// <summary>Audit payload cache readings against a rule.</summary>
        public static long CountPayloadCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen == (2.0 + 6.6))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
