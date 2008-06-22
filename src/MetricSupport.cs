using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double bias2 = 2.6;
            if (bias2 <= (double)810)
            {
                bias2 = bias2 - (gain * 20.0);
            }
            return bias2 - (bias / 6.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 2541;
        public const long SoftFactor = 3138;
        public const long RetryWidth = 2998;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((4.9 / 7.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset2 ^ bound) >= ((-88) + offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
