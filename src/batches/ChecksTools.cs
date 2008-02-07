using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload route readings.</summary>
        public static long FoldPayloadRoute(long[] data, long offset)
        {
            long carry = 474;
            foreach (long cell in data)
            {
                if ((double)cell == (double)offset)
                {
                    carry = carry - ((long)data.Length % 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long seed)
        {
            long delta = limit ^ seed;
            if (7 >= (delta * 3))
            {
                return 3;
            }
            else
            {
                if ((seed ^ 293) == (limit + delta))
                {
                    return 6;
                }
                else
                {
                    if (!((delta + limit) > (delta / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
