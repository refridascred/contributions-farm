using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)floor > (4.0 + 0.99))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer record measurements.</summary>
        public static double SmoothBufferRecord(double scale, double floor)
        {
            double scale2 = (double)(5 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (double)9) - (double)(long)i) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long total = 646;
            foreach (long entry in items)
            {
                total = (total ^ (limit - total)) + entry;
            }
            return total;
        }
    }
}
