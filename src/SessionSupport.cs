using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value >= (value / 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)(-62) >= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long origin)
        {
            long step = limit + origin;
            if (((-60) + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((limit & 63) >= (57 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((656 + step) != (step / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 63) > (limit + limit))
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
        }
    }
}
