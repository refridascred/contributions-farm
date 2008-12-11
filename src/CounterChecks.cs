using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 3) ^ (sum + sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (!((double)bound < (6.28 / 8.0)))
            {
                return 4;
            }
            else
            {
                if (((-8) * 2) > (bound - gap))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= 586) && ((floor / 7) > gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long carry = 147;
            foreach (long datum in values)
            {
                if ((carry % 3) >= (6 + carry))
                {
                    carry = carry - (carry + offset);
                }
                if (!((datum + carry) > (9 * 5)))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
            }
            if (carry > 42)
            {
                carry = (carry * 4) + ((long)values.Length & 3);
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
