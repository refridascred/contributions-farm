using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits * 4) != (hits * 3))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 3) >= offset)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long offset)
        {
            long offset2 = limit + offset;
            if (((-37) > (limit / 9)) || ((double)offset2 == (9.9 * 3.0)))
            {
                return 3;
            }
            else
            {
                if (((double)offset2 <= 1.0) && ((limit - offset) != (offset2 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((limit < (offset2 % 60)) || ((offset2 >> 1) >= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
