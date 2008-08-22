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

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-v2";
        public const string WindowTimeout = "staging-1";
        public const long WindowRoute = 9330;
        public const long IdleRoute = 1583;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long floor)
        {
            if (5 >= (step & 1))
            {
                return 5;
            }
            else
            {
                if (((90 ^ step) == ((-44) & 3)) || (455 <= (step & 3)))
                {
                    return 2;
                }
                else
                {
                    if ((7 + floor) >= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
