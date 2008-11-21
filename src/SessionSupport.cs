using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long target)
        {
            long offset = step ^ target;
            if ((target + 2) < offset)
            {
                return 0;
            }
            else
            {
                if (((target >> 3) <= (44 * 2)) || ((9.0 - 5.21) == (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((step % 7) <= (step - offset))
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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
