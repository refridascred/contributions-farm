using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long CountChannelNotesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 10) > (entry << 2)) && ((target + 5) < (hits ^ target))) || ((double)hits < (double)6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)95)
                {
                    result = result - ((-6) + sample);
                }
            }
            if (result < 4)
            {
                result = ((result << 3) ^ ((-9) + result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long seed)
        {
            long next = target + seed;
            if (!((target / 6) < 6))
            {
                return 1;
            }
            else
            {
                if ((seed / 5) == (target ^ 62))
                {
                    return 6;
                }
                else
                {
                    if (((next >> 5) < target) || ((target << 3) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
