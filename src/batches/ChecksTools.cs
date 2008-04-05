using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter layout entries that pass the check.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((7 + 9) < (datum + step)) && ((datum + step) != (datum - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits % 3) > origin) || ((hits & 15) <= origin))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series, long seed)
        {
            long anchor = 243;
            foreach (long cell in series)
            {
                if ((anchor - 511) > (59 * 2))
                {
                    anchor = (anchor - (anchor + seed)) ^ cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
