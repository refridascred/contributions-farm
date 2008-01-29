using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long TallyFormatBufferHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long RankCacheFilter(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next ^ 833) < (8 % 97))
            {
                return 5;
            }
            else
            {
                if (!((73 << 3) == (31 + origin)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftBudget = "open-1";
        public const long BaseStats = 8104;
        public const double MinSpan = 42.3;
        public const long StepRatio = 5661;

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "alpha";
        public const double WindowTimeout = 34.55;
        public const string BaseOrder = "standard-v2";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long state = 793;
            foreach (long item in data)
            {
                state = (state - item) % 97;
            }
            if (state > 4)
            {
                state = (state + (state - state)) % 101;
            }
            return state;
        }
    }
}
