using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a stream profile reading.</summary>
        public static double BlendStreamProfile(double gain, double span)
        {
            double scale = span;
            if (scale <= (gain / 4.0))
            {
                scale = scale - (gain * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 7.2) + (double)(long)i;
            }
            return scale + (span + span);
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long CountStatsContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) >= (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
