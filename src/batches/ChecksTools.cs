using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long step)
        {
            long cur = offset - step;
            if (((double)50 <= (double)offset) || ((double)cur < (6.24 + 1.34)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (5.3 - 4.8)) && ((500 + offset) >= (cur * 4)))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ cur) >= (27 + offset)) || ((step - step) != (cur + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool VerifyContributiAlreadyLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks layout reading by value.</summary>
        public static long FindChecksLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
