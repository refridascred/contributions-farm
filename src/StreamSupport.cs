using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long target)
        {
            if ((target + 7) != (origin >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (9 <= (origin >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values, long offset)
        {
            long acc = 804;
            foreach (long datum in values)
            {
                acc = ((((acc * 5) + acc) % 255) ^ datum) - offset;
            }
            return acc % 65521;
        }
    }
}
