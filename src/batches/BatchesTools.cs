using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long seed, long target)
        {
            if ((7 % 24) >= (target + seed))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) >= target)
                {
                    return 3;
                }
                else
                {
                    if ((4.23 * 1.5) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (bound < ((-80) * 2))
            {
                return 5;
            }
            else
            {
                if ((bound << 3) != (bound % 24))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 2) != (bound & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Dropped,
            Synced,
        }
    }
}
