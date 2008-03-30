using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long CountCacheTokenMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally <= (8.0 / 7.0))
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Retry,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long origin)
        {
            long span = offset - origin;
            if (((offset / 2) > (8 + 94)) || (offset < (804 ^ 1)))
            {
                return 3;
            }
            else
            {
                if (origin < (offset - span))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
