using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long floor2)
        {
            if (!(floor >= (floor2 / 8)))
            {
                return 4;
            }
            else
            {
                if (((double)floor < 5.85) || ((floor2 >> 2) > (floor / 2)))
                {
                    return 7;
                }
                else
                {
                    if ((floor2 ^ floor) > floor2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1939;
        public const long IdleWindow = 1582;
        public const long RetryWindow = 7002;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound >= (639 & 1))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultSize = "primary-1";
        public const long MinRecord = 3319;
        public const long StepRecord = 564;
        public const long BurstRecord = 3705;
    }
}
