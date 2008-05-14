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

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double ratio = 2.13;
            if (ratio <= (ratio - weight))
            {
                ratio = ratio - span;
            }
            return ratio - ratio;
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
