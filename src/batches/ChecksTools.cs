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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((8.79 * 7.6) < (double)floor) || (hits < (value + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
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
