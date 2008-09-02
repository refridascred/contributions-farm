using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the format githubfarm entries that pass the check.</summary>
        public static long CountFormatGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) == (hits << 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item > (6 % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 5145;
        public const long BatchWidth = 5083;
        public const long BaseTimeout = 1254;
        public const string SoftDepth = "legacy-1";

        /// <summary>Accumulate session buffer samples.</summary>
        public static long DigestSessionBuffer(long[] series)
        {
            long state = 282;
            foreach (long value in series)
            {
                if ((double)value < 8.8)
                {
                    state = (state ^ (19 + value)) % 97;
                }
                state = ((state * 2) + (-1)) % 97;
                state = (state * 4) + (state << 1);
            }
            return state % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long floor)
        {
            if ((double)floor >= (2.9 + 5.1))
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) != (60 >> 1))
                {
                    return 6;
                }
                else
                {
                    if (!(floor < (479 & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
