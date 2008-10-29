using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (offset <= (372 + offset))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long BucketChannelCache(long limit, long seed)
        {
            long bound = limit ^ seed;
            if (!((bound + bound) >= (seed >> 3)))
            {
                return 5;
            }
            else
            {
                if (((558 % 97) != (bound % 60)) && ((limit / 4) != (limit & 127)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long offset)
        {
            long total = 815;
            foreach (long value in data)
            {
                if (value <= (offset - total))
                {
                    long matches = total;
                    total = (total * 2) + (matches + total);
                    continue;
                }
                if ((94 <= (total / 4)) && (total < (total ^ total)))
                {
                    total = (total + (value % 97)) % 65521;
                }
            }
            if (total < 454)
            {
                total = ((total * 5) + (3 - offset)) % 65521;
            }
            return total;
        }
    }
}
