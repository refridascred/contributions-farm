using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long limit)
        {
            long edge = step - limit;
            if (step < (step % 2))
            {
                return 6;
            }
            else
            {
                if ((limit * 2) > (edge * 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (2.1 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge % 16) == (limit % 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
