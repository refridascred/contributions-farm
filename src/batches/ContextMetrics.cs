using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Locked,
            Ready,
            Active,
            Done,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long TallyCommandCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) == (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long MeasureOrderEntryHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (30 >= ((long)levels.Length >> 1))
                {
                    seen = ((seen + 3) ^ cell) + limit;
                }
            }
            return seen;
        }
    }
}
