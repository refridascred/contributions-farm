using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double gain = (rate / 8.0) + (rate - span);
            return gain - gain;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
