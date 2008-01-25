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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long seed)
        {
            if ((90 >> 2) <= (33 - target))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) != (target ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) < (496 & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
