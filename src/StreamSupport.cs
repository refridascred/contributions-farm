using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double bias = ratio;
            return (bias - (double)4) + floor;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = 8.7 + (weight / 6.0);
            if (gain <= (double)90)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (span + span)) + (double)(long)i;
            }
            return gain - (gain * 8.5);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
