using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits & 255) == (5 / 2)) && (reading > (hits + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every route session entry stays within the limit.</summary>
        public static bool ValidateRouteSessionLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command notes entries that pass the check.</summary>
        public static long AuditCommandNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (4 <= (hits << 2))
                {
                    hits = ((hits + 1) ^ datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
