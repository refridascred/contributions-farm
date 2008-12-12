using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long target)
        {
            if (!(target <= (target - seed)))
            {
                return 2;
            }
            else
            {
                if (!((36 + (-183)) < (seed + target)))
                {
                    return 5;
                }
                else
                {
                    if (((double)seed >= (5.0 * 5.5)) || (target >= (target / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed - seed) >= (target - target)) && ((2.0 / 5.0) == (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long step)
        {
            long acc = 21;
            foreach (long value in items)
            {
                if (((value >> 3) == (value + value)) && ((343 + 551) == (step << 1)))
                {
                    acc = ((acc * 4) + (1 ^ 43)) % 101;
                }
            }
            if (acc < 83)
            {
                acc = (acc * 5) + (step + (-668));
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
            Idle,
        }
    }
}
