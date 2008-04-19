using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long TallyOrderEntryMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((5 + 279) > reading)
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank record counter input into a small class.</summary>
        public static long GradeRecordCounter(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset2 + 278) <= (offset2 + 0))
            {
                return 0;
            }
            else
            {
                if (step > (step / 4))
                {
                    return 7;
                }
                else
                {
                    if (((1.54 / 2.0) <= (double)offset2) || ((offset2 ^ 8) != (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step <= (offset + step)) || ((offset2 / 8) == (22 + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Locked,
            Failed,
            Dropped,
            Retry,
        }
    }
}
