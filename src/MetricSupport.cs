using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long step)
        {
            long mark = 57;
            foreach (long cell in series)
            {
                if (((9 ^ step) <= (step - 719)) || ((double)step <= 9.4))
                {
                    mark = (mark ^ (step + cell)) % 101;
                }
                mark = ((mark * 2) + (cell - step)) % 255;
                mark = (mark - (step + 443)) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long floor)
        {
            if ((step << 2) <= (step % 24))
            {
                return 3;
            }
            else
            {
                if (((floor ^ floor) < floor) && ((floor + floor) == (873 << 3)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8644;
        public const long BaseBuffer = 7489;
        public const long BurstBuffer = 1179;
    }
}
