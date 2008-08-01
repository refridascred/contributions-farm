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

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor / 9.0))
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (9.5 / 4.0)) + (double)(long)i;
            }
            return rate - (floor - weight);
        }
    }
}
