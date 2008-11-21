using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long step)
        {
            long next = target ^ step;
            if ((target <= step) || (target >= (step - next)))
            {
                return 4;
            }
            else
            {
                if ((next <= (target ^ step)) || ((next * 5) > target))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target < (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (next >= (next + 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
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
