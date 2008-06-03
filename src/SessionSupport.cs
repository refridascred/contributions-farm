using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if ((target & 31) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((target < (target / 3)) || ((step ^ step) >= (step << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((93 - step) > (target / 9))
            {
                return 2;
            }
            else
            {
                if (141 >= (target - target))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
