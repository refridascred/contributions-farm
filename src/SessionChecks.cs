using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool ValidateFilterQueueLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state * 2) + (origin - 66);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks stream entries.</summary>
        public static long TotalChecksStream(long[] levels)
        {
            long mark = -48;
            foreach (long reading in levels)
            {
                mark = (mark * 2) + (mark + reading);
                if (reading > mark)
                {
                    mark = (mark ^ mark) % 255;
                }
                else
                {
                    mark = (mark - (3 % 60)) % 97;
                }
            }
            return mark % 4096;
        }
    }
}
