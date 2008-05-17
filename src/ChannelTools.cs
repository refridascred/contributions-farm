using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Synced,
            Retry,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long result = -92;
            foreach (long reading in values)
            {
                if ((result * 3) > ((long)values.Length + 531))
                {
                    result = (((result + result) % 4096) - reading) - seed;
                }
                if (!(((long)values.Length - result) != (5 + 3)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
