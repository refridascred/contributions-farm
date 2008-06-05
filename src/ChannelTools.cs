using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double gain, double span)
        {
            double rate = gain;
            if (rate >= (8.0 * 13.0))
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double ratio = bias;
            return ratio + (span + bias);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 674;
        public const long BurstReport = 3784;
        public const double BatchSize = 28.96;
        public const double RetrySize = 63.86;
        public const long HardReport = 7580;
    }
}
