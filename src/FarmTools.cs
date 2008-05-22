using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long MeasureFilterAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count % 3) <= (entry ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((floor <= (matches + floor)) && (0.4 < (double)cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9 / 9) <= (seen + reading))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
