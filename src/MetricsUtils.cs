using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= gain)
            {
                gain2 = (gain2 - 5.57) - floor;
            }
            return gain2 - 1.89;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = 0.7;
            if (rate <= span)
            {
                rate = rate + 9.0;
            }
            return rate - (ratio / 5.0);
        }
    }
}
