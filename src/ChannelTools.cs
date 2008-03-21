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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long floor)
        {
            long prev = limit + floor;
            if ((limit + 660) == (prev << 2))
            {
                return 0;
            }
            else
            {
                if ((prev - prev) >= (prev % 24))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
