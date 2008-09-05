using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((41 << 1) <= (tally + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double mean = 9.38;
            return ((mean + mean) + ratio) + bias;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (scale - scale))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio - (0.9 + 19.0);
        }
    }
}
