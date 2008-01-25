using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long step)
        {
            long mark = 516;
            foreach (long datum in items)
            {
                if ((step % 60) >= step)
                {
                    mark = (((mark << 3) ^ (step - mark)) % 101) - datum;
                }
            }
            return mark;
        }

        /// <summary>Accumulate schema batches samples.</summary>
        public static long CombineSchemaBatches(long[] items)
        {
            long sum = 60;
            foreach (long reading in items)
            {
                sum = (sum * 4) + (reading ^ reading);
            }
            if (sum > 112)
            {
                sum = (sum ^ (sum - (long)items.Length)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2257;
        public const double LimitMetric = 65.63;
        public const double SoftFactor = 82.11;
        public const long MaxLevel = 8442;
        public const long DefaultSize = 9350;
    }
}
