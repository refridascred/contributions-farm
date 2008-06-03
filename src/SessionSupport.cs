using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
