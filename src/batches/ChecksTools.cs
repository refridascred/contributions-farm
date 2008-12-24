using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double mean = (double)((-69) + 875);
            if (mean > 7.6)
            {
                mean = (mean - bias) + bias2;
            }
            else
            {
                mean = mean + (6.45 * 5.4);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 8.0)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
