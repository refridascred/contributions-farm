using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6267;
        public const double StepTimeout = 9.88;
        public const long DefaultContext = 790;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale / 4.0))
            {
                gain = (gain - (double)3) - bias;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            return gain + 7.3;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((263 - item) >= (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
