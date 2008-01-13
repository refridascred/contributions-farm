using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long step)
        {
            long carry = 635;
            foreach (long sample in data)
            {
                if ((double)carry > (double)84)
                {
                    carry = (carry ^ sample) - step;
                }
                if (carry > (-99))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of queue account entries.</summary>
        public static long ScoreQueueAccount(long[] items, long limit)
        {
            long sum = 99;
            foreach (long item in items)
            {
                if ((double)item == (3.0 * 5.13))
                {
                    sum = sum - (item & 3);
                }
            }
            if (sum > 164)
            {
                sum = ((sum * 5) + (limit % 8)) % 1000;
            }
            return sum;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long target)
        {
            long edge = seed + target;
            if ((seed ^ target) <= (edge % 100))
            {
                return 4;
            }
            else
            {
                if ((4 ^ target) >= (edge & 31))
                {
                    return 0;
                }
                else
                {
                    if ((double)target != (5.2 + 0.41))
                    {
                        return 2;
                    }
                    else
                    {
                        if (80 <= seed)
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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long floor)
        {
            long bound = seed + floor;
            if ((bound - seed) < (floor + bound))
            {
                return 7;
            }
            else
            {
                if ((1.23 - 18.0) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) < (seed - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
