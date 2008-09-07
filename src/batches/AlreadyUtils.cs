using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long seed)
        {
            if ((seed + seed) > (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 15) >= (bound + seed))
                {
                    return 6;
                }
                else
                {
                    if ((8.0 / 4.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 + (-669)) == (bound + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Closed,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long seed)
        {
            long result = 898;
            foreach (long datum in values)
            {
                result = result - (seed / 2);
                if (!((6.9 - 4.5) < (double)datum))
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = (result << 3) ^ seed;
            }
            return result % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ (9 * 4)) % 65521) ^ (long)i2;
                }
                if ((double)bound == (5.9 - 7.2))
                {
                    acc = ((acc << 3) ^ (33 % 7)) % 65521;
                }
                if ((bound >> 1) < bound)
                {
                    acc = (acc << 3) ^ (bound << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
