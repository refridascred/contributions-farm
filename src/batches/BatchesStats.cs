using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((13.0 - 3.32) >= (double)hits)
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftRatio = 36.91;
        public const long HardSize = 5104;
        public const long BaseInterval = 1803;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double bias = (span + span) - (double)1;
            if (bias <= ratio)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (span * 0.4);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Draft,
            New,
            Active,
        }
    }
}
