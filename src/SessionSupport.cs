using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel session entries that pass the check.</summary>
        public static long TallyChannelSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count - count) != (count & 1)) || ((long)samples.Length > 4))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool GuardFormatClusterLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double mean = bias - (bias / 9.0);
            if (mean >= (mean - mean))
            {
                mean = mean - (7.0 + weight);
            }
            else
            {
                mean = mean - weight;
            }
            return mean + (double)29;
        }
    }
}
