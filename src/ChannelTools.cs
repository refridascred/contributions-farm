using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (((623 % 100) > (origin - origin)) && ((64 + bound) > origin2))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) < (bound / 9))
                {
                    return 2;
                }
                else
                {
                    if (!(7 <= (bound - origin2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - matches) != (floor * 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long AuditAccountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(7 < count))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
