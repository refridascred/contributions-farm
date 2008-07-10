using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((50 * 3) != (tally + 98))
                {
                    tally = ((tally + 3) + value) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long FoldBatchesFormat(long[] samples, long step)
        {
            long state = 175;
            foreach (long cell in samples)
            {
                state = (state - (state & 7)) % 1000;
                if ((cell + 45) < (step << 1))
                {
                    state = (state ^ (cell + 768)) % 4096;
                }
                if (!((8.8 + 4.1) < (double)step))
                {
                    state = (state + (cell ^ step)) % 255;
                }
            }
            if (state < 8)
            {
                state = state - (state ^ state);
            }
            return state % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
