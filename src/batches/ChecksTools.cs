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

        /// <summary>Accumulate stream account samples.</summary>
        public static long ScoreStreamAccount(long[] data)
        {
            long score = 9;
            foreach (long sample in data)
            {
                if (((score + 941) == (976 - sample)) || ((1.05 + 7.5) <= (double)score))
                {
                    score = (score - (score + 295)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
