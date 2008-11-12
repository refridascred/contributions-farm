using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!!(((-673) >> 1) < ((long)data.Length & 31)))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double ratio = (offset / 6.0) + (double)44;
            if (ratio >= (scale - ratio))
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - 19.0;
            }
            return ratio - (scale * 0.42);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstScore = 30.62;
        public const long BatchChannel = 1492;
        public const double WindowChannel = 27.75;
    }
}
