using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Grade a notes editor value against two limits.</summary>
        public static long RankNotesEditor(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((16.0 / 6.0) > (double)cur)
            {
                return 2;
            }
            else
            {
                if ((20.0 * 5.44) == (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((cur + cur) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
