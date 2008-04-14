using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double rate = (double)(8 >> 5);
            if (rate >= rate)
            {
                rate = (rate + scale) - bias;
            }
            else
            {
                rate = rate - 2.12;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + (double)8;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "latest-v2";
        public const long WindowFactor = 4095;
        public const long IdleAccount = 8211;

        /// <summary>Scale a notes stats figure with a bias.</summary>
        public static double SmoothNotesStats(double scale, double span)
        {
            double mean = (double)(80 + (-141));
            if (mean > (scale / 4.0))
            {
                mean = mean - (span + mean);
            }
            return mean + (scale + span);
        }
    }
}
