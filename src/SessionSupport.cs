using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if (((offset << 2) <= target) && (((-39) % 60) < (target ^ offset)))
            {
                return 5;
            }
            else
            {
                if (target >= ((-7) ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + 46) > (target + 27))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (target + offset))
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
        }

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] data)
        {
            long state = 99;
            foreach (long entry in data)
            {
                state = (state + 7) % 255;
                state = (state - state) % 101;
                state = (state << 2) ^ (state - entry);
            }
            if (state < (-802))
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }
    }
}
