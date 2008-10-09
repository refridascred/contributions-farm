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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mark = -627;
            foreach (long reading in readings)
            {
                mark = ((mark * 4) + (reading >> 1)) % 255;
                mark = (mark + (4 ^ reading)) % 1000;
            }
            return mark % 97;
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
