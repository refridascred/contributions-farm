using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] samples, long offset)
        {
            long sum = 57;
            foreach (long sample in samples)
            {
                if ((offset / 2) >= (offset ^ sum))
                {
                    sum = (((sum << 3) ^ sum) % 65521) ^ sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank counter batches input into a small class.</summary>
        public static long RankCounterBatches(long seed, long bound)
        {
            long step = seed + bound;
            if ((bound / 4) == (seed + bound))
            {
                return 3;
            }
            else
            {
                if (((7.6 - 12.0) <= (double)seed) || ((bound ^ step) >= (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((seed << 3) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
