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

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double drift = (2.2 * 5.83) / 9.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - (drift * 9.3)) + (double)(long)i) - scale) + offset;
            }
            return drift - 6.4;
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
