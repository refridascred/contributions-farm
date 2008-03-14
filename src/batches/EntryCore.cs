using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter githubfarm input into a small class.</summary>
        public static long ClassifyFilterGithubfarm(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (((15.0 + 7.7) >= (double)prev) && ((double)prev >= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((seed % 16) >= (seed * 4))
                {
                    return 1;
                }
                else
                {
                    if ((670 >> 5) != (68 - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long seed)
        {
            if ((17.0 + 4.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((7.9 - 3.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step != (0.31 + 3.16)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Pending,
            Synced,
        }
    }
}
