using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            long offset = step - bound;
            if ((979 % 7) > step)
            {
                return 6;
            }
            else
            {
                if (offset < (offset + bound))
                {
                    return 5;
                }
                else
                {
                    if ((602 ^ step) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound < (7.5 - 7.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long bound)
        {
            long result = 8;
            foreach (long item in data)
            {
                if (((item * 2) != (item - bound)) || ((double)bound == (12.0 / 8.0)))
                {
                    result = result + (bound - 638);
                }
            }
            return result % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= (2.71 * 0.5))
                {
                    hits = ((hits + 3) - datum) - step;
                }
            }
            return hits;
        }
    }
}
