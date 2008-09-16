using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.8 / 5.0) <= (double)(long)i))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 4096;
                    sum = ((sum * 2) + (step - sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            long slot = floor - bound;
            if (slot >= (bound * 2))
            {
                return 4;
            }
            else
            {
                if (!((bound + slot) <= slot))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long mark = 942;
            foreach (long cell in samples)
            {
                mark = (mark - (mark - seed)) ^ cell;
            }
            return mark;
        }
    }
}
