using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double mean = weight;
            if (mean > weight)
            {
                mean = (mean + (weight / 4.0)) + span;
            }
            else
            {
                mean = mean - (weight + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)84) + (double)(long)i;
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Blend two route commits measurements.</summary>
        public static double ProjectRouteCommits(double bias, double bias2)
        {
            double gain = (double)(429 << 3);
            if (gain >= (gain - bias))
            {
                gain = gain + (bias2 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)265) - (double)(long)i;
            }
            return gain + (bias + bias);
        }
    }
}
