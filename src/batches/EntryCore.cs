using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Queued,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 7216;
        public const double MaxDepth = 52.82;
        public const long HardFactor = 5808;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a token cache sample.</summary>
        public static long FindTokenCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long CombineQueueFarm(long[] series)
        {
            long carry = 473;
            foreach (long value in series)
            {
                carry = ((carry - (carry << 2)) % 101) ^ value;
            }
            if (carry > 9)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
