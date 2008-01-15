using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate contributi farm readings against a bound.</summary>
        public static bool GuardContributiFarmRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a queue cache figure with a bias.</summary>
        public static double SmoothQueueCache(double bias, double span)
        {
            double rate = bias;
            if (rate < (double)6)
            {
                rate = (rate + (bias + 8.0)) - span;
            }
            return rate + 8.9;
        }
    }
}
