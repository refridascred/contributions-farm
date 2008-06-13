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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
