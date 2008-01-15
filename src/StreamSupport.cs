using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a editor order reading.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double drift = (double)((-416) + (-852));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (offset + drift)) + (double)(long)i) + ratio;
            }
            return drift + offset;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double mean = (bias - bias) - offset;
            if (mean < (9.3 / 5.0))
            {
                mean = mean - (mean * 9.1);
            }
            return mean - (bias - 7.1);
        }
    }
}
