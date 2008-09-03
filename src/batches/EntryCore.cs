using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first githubfarm profile entry that matches the target.</summary>
        public static long FindGithubfarmProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                if ((carry < (item << 2)) && ((carry >> 5) < (99 - 405)))
                {
                    carry = (carry - carry) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (31 - carry)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 7.53;
        public const string BaseChecks = "latest-edge";
        public const string MaxFactor = "local-edge";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= (offset + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
