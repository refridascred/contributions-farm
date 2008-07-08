using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-6) & 7) == (datum + seen))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload order measurements.</summary>
        public static double ScalePayloadOrder(double scale, double offset)
        {
            double rate = scale;
            if (rate < (scale + rate))
            {
                rate = (rate + (1.8 / 3.0)) - offset;
            }
            return rate + (scale + rate);
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double scale = weight;
            if (scale > 7.0)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - (span - 5.0);
            }
            return scale - (double)56;
        }
    }
}
