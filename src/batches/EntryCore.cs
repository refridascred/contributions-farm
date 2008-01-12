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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long sum = 938;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum ^ (961 - (long)i)) % 4096;
                    sum = sum ^ (floor * 2);
                }
                if (((sum << 3) <= (floor + 4)) || ((floor >> 3) > (datum - datum)))
                {
                    sum = ((sum * 2) + (sum >> 1)) % 1000;
                }
            }
            return sum % 65521;
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
