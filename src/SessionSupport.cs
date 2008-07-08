using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items, long limit)
        {
            long score = 48;
            foreach (long cell in items)
            {
                score = (score - (limit / 9)) - cell;
            }
            return score;
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
