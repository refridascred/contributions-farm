using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double rate = (bias * 0.1) / 4.0;
            if (rate < (gain / 8.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias / 2.0)) + (double)(long)i;
            }
            return rate - (bias / 9.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long anchor = 551;
            foreach (long cell in readings)
            {
                if (!((cell << 3) > anchor))
                {
                    anchor = ((anchor << 2) ^ 355) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5425;
        public const string SoftQueue = "local";
        public const double BurstInterval = 85.48;
        public const long HardQueue = 3584;
        public const long BaseBudget = 6358;
    }
}
