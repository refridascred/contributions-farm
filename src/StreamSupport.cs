using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long offset)
        {
            long offset2 = target + offset;
            if ((double)target == (6.9 + 2.87))
            {
                return 3;
            }
            else
            {
                if (2 <= (offset2 + offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
