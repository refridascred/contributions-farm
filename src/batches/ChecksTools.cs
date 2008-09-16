using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count >= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                long offset = (21 + mark) & 1;
                if ((double)offset <= (double)floor)
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                else
                {
                    offset = (offset << 2) ^ offset;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
