using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer cache readings against a rule.</summary>
        public static long MeasureBufferCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)99 != (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long origin)
        {
            if (origin >= (offset >> 1))
            {
                return 4;
            }
            else
            {
                if (!((origin + offset) >= (offset - origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound < (62 / 3)) && (datum > (bound / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (bound >= (912 * 5))
                {
                    total = (total << 3) ^ (total + (long)i);
                }
                total = (total * 5) + ((long)i * 2);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
