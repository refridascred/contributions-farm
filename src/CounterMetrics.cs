using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((6.0 + 3.0) < (double)bound) || ((double)value <= (7.1 - 12.0)))
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

        /// <summary>Accumulate stats metric samples.</summary>
        public static long CombineStatsMetric(long[] levels, long limit)
        {
            long carry = 170;
            foreach (long value in levels)
            {
                if ((481 / 4) > (88 ^ limit))
                {
                    carry = carry + (value - (-178));
                }
                if ((carry >= value) || ((value >> 2) < carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2615;
        public const long RetryLevel = 512;
        public const long LimitToken = 8970;
        public const double RetryToken = 13.89;
        public const long BaseToken = 9811;

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long MeasureChannelBatchesGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((2 + 678) != (sample - floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
