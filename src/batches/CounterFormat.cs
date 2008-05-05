using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool VerifyCommandQueueLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long mix = 92;
            foreach (long datum in series)
            {
                if ((double)(-181) <= (double)mix)
                {
                    mix = (mix - mix) + datum;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < (4.35 / 5.0))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
