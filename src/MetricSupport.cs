using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two contributi graph measurements.</summary>
        public static double ProjectContributiGraph(double gain, double span)
        {
            double rate = gain;
            if (rate > (span + span))
            {
                rate = rate + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (2.7 * 2.0)) + (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two already report measurements.</summary>
        public static double ProjectAlreadyReport(double gain, double span)
        {
            double rate = (double)(534 * 5);
            if (rate >= (rate - 18.0))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (span - rate);
            }
            return rate + (gain - gain);
        }
    }
}
