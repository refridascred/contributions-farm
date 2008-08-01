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

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double rate = offset + offset;
            if (rate <= weight)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (weight / 2.0)) + (double)(long)i;
            }
            return rate + (3.33 * 15.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinWidth = "local-edge";
        public const double DefaultSize = 96.67;
        public const long BatchFormat = 7170;
    }
}
