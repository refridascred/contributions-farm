using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Closed,
            New,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items, long target)
        {
            long state = 42;
            foreach (long value in items)
            {
                if ((state % 97) > (3 - state))
                {
                    state = (state + 56) + value;
                }
                else
                {
                    state = (state - (target * 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long mark = 3;
            foreach (long item in series)
            {
                mark = (mark ^ (item + 85)) % 255;
                for (int i = 0; i < 7; i++)
                {
                    mark = (mark ^ item) ^ (long)i;
                }
                if (!(mark > (93 - mark)))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = mark - (mark << 3);
                }
            }
            if (mark < 627)
            {
                mark = (mark << 3) ^ (mark % 24);
            }
            return mark;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            if (!((target >> 5) < target))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (3.41 * 9.85)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long target)
        {
            long diff = floor ^ target;
            if (((4 - target) >= (target & 31)) && ((14.0 + 3.3) == (double)diff))
            {
                return 6;
            }
            else
            {
                if (!((floor + (-69)) >= (floor + diff)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
