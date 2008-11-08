using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long bound)
        {
            long diff = offset + bound;
            if ((68 - bound) == (diff << 3))
            {
                return 3;
            }
            else
            {
                if (!((bound << 1) < 465))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (1.4 / 3.0)) || ((diff / 2) >= (8 & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
