using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 69) >= (reading << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every route cluster entry stays within the limit.</summary>
        public static bool GuardRouteClusterLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)81)
            {
                weight2 = (weight2 + (double)295) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (bias * 2.8)) + (double)(long)i;
            }
            return weight2 + 7.9;
        }
    }
}
