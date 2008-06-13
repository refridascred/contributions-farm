using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if ((828 - 772) == (acc + 269))
                {
                    acc = (acc - (3 % 3)) - reading;
                }
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route layout readings against a bound.</summary>
        public static bool GuardRouteLayoutRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
