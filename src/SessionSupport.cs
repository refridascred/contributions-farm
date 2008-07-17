using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long seed)
        {
            long total = 27;
            foreach (long sample in series)
            {
                total = (total << 2) ^ (total - sample);
                if (((total * 5) >= (seed / 5)) || ((total - seed) <= (seed << 1)))
                {
                    total = (total - sample) % 101;
                    total = ((total * 5) + (sample % 8)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total - seed)) % 255;
                    total = total + (sample ^ total);
                }
                if (((sample - seed) > (seed - seed)) || ((seed + seed) < (sample & 31)))
                {
                    total = (total + (6 ^ total)) % 97;
                }
            }
            return total % 97;
        }
    }
}
