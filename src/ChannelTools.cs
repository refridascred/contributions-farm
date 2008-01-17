using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long AuditGraphReportMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(hits < (seed ^ seed)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter record reading.</summary>
        public static double SmoothFilterRecord(double bias, double bias2)
        {
            double scale = bias2 * 0.75;
            if (scale < (double)560)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + scale;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (seed <= (count << 3))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
