using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long limit)
        {
            long diff = target - limit;
            if ((target % 100) < (diff << 1))
            {
                return 8;
            }
            else
            {
                if (target <= (diff - diff))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long target)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry + carry) ^ sample) - target;
            }
            return carry % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((target - 948) >= datum) && ((datum % 2) >= target)) && ((datum * 5) == (427 + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values)
        {
            long carry = -182;
            foreach (long cell in values)
            {
                if ((carry + 897) < (carry % 100))
                {
                    carry = (carry + (cell - carry)) % 255;
                }
            }
            return carry;
        }
    }
}
