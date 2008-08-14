using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long mark = 12;
            foreach (long item in levels)
            {
                if ((double)item >= (9.0 - 16.0))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
                mark = mark - (step - mark);
            }
            return mark % 65521;
        }

        /// <summary>Scale a stats token figure with a bias.</summary>
        public static double BlendStatsToken(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)(-6))
            {
                rate = (rate - 11.0) - scale;
            }
            else
            {
                rate = rate - (rate * 5.0);
            }
            return rate + (11.0 - span);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (scale - bias))
            {
                bias2 = bias2 + (double)533;
            }
            return bias2 + bias;
        }
    }
}
