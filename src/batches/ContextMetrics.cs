using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate entry format samples.</summary>
        public static long FoldEntryFormat(long[] items, long target)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if ((215 + target) >= 26)
                {
                    mix = ((mix + ((long)items.Length + mix)) % 1000) ^ sample;
                }
                else
                {
                    mix = (mix ^ (target * 3)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((double)8 < (8.36 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((floor ^ floor) < (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 9012;
        public const long CacheWidth = 4580;
        public const long RetryInterval = 8028;
        public const long IdleScore = 6729;
        public const long BaseLevel = 1003;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Idle,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long carry = 512;
            foreach (long entry in levels)
            {
                carry = ((carry * 4) + (carry / 3)) % 4096;
                if ((seed - seed) >= (carry - entry))
                {
                    carry = ((carry << 2) ^ (-69)) % 97;
                }
                else
                {
                    carry = (carry + (742 % 8)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (seed - carry);
            }
            return carry;
        }
    }
}
