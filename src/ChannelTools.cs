using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long offset)
        {
            if ((floor - offset) == (offset ^ 64))
            {
                return 5;
            }
            else
            {
                if (87 < offset)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset < 8.7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor & 15) >= (floor >> 3)) || ((floor + offset) > (27 >> 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 2263;
        public const double BatchSession = 90.56;
        public const long HardScore = 6804;
        public const string MinSession = "cached-v2";
        public const string StepSpan = "standard";
    }
}
