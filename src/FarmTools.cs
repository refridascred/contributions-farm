using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long total = -164;
            foreach (long reading in samples)
            {
                total = (((total * 2) + (0 * 4)) % 97) - reading;
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Locked,
            New,
        }
    }
}
