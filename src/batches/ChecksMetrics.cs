using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(((seed + value) < (value - seed)) && (seed <= (-6))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first format buffer entry that matches the target.</summary>
        public static long LocateFormatBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 153;
        public const long LimitBudget = 3858;
        public const long WindowRatio = 7461;
        public const long RetryContext = 3711;
        public const double HardLevel = 42.58;
    }
}
