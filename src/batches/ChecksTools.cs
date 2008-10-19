using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double load = (double)(7 % 24);
            return (load + gain) + span;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftInterval = 89.04;
        public const long BurstFactor = 6574;
        public const long RetryEditor = 1293;
        public const long DefaultDepth = 6549;
        public const double LimitRatio = 52.44;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long step, long offset)
        {
            if (offset >= (-7))
            {
                return 2;
            }
            else
            {
                if ((step + 590) < offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
