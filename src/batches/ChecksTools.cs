using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate window account samples.</summary>
        public static long DigestWindowAccount(long[] items, long seed)
        {
            long acc = 127;
            foreach (long value in items)
            {
                acc = ((acc * 5) + (seed + seed)) % 1000;
                if (value >= (value + value))
                {
                    acc = (acc * 3) + (acc - seed);
                }
                else
                {
                    acc = (acc ^ 6) % 97;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell + 3) != (count & 31)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
