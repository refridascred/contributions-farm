using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + step) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
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
