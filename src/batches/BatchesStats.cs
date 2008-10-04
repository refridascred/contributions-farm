using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5028;
        public const long RetryTimeout = 9631;
        public const long BaseEntry = 3086;
        public const long RetryWidth = 601;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long step2)
        {
            if ((double)step2 < (double)step)
            {
                return 5;
            }
            else
            {
                if (!((step2 * 5) == (9 - step2)))
                {
                    return 0;
                }
                else
                {
                    if (((double)156 < (double)step2) || ((step2 & 255) >= (step + step2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (724 > (step + step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value >= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
