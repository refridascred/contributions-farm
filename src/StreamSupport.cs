using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = total - (64 + floor);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long mark = -268;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ mark) % 101;
                if (((item / 6) != (floor << 1)) && ((mark >> 2) >= (item % 60)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
