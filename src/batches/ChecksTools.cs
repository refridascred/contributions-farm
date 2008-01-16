using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor stream readings.</summary>
        public static long ScoreEditorStream(long[] items)
        {
            long sum = 11;
            foreach (long sample in items)
            {
                sum = ((sum * 3) + (58 - sample)) % 65521;
                sum = ((sum * 5) + (837 + sum)) % 1000;
            }
            if (sum < 981)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Retry,
            Pending,
            Synced,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long diff = floor - target;
            if (floor >= (target >> 1))
            {
                return 7;
            }
            else
            {
                if (((target ^ floor) <= floor) && ((double)target >= (0.3 + 5.75)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 / 3.0) == (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor <= diff))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
