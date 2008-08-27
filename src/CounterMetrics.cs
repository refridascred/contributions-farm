using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data, long step)
        {
            long mark = -90;
            foreach (long item in data)
            {
                mark = (mark - mark) - item;
                mark = (mark - step) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((3 % 64) != (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long cur = limit + target;
            if ((double)limit >= (double)cur)
            {
                return 4;
            }
            else
            {
                if (6.5 > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - cur) >= (0 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
