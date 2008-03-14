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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values)
        {
            long result = 42;
            foreach (long entry in values)
            {
                if ((result >= (7 + entry)) || ((result - result) == ((long)values.Length + entry)))
                {
                    result = (result * 4) + (result * 4);
                }
            }
            return result % 4096;
        }
    }
}
