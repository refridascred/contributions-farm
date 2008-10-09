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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings, long origin)
        {
            long total = 745;
            foreach (long sample in readings)
            {
                if ((6.6 - 0.69) >= (double)origin)
                {
                    total = ((total ^ total) % 1000) ^ sample;
                }
            }
            if (total < 55)
            {
                total = (total << 2) ^ (total % 5);
            }
            return total;
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
