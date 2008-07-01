using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a session batches value against two limits.</summary>
        public static long GradeSessionBatches(long limit, long step)
        {
            if ((limit + step) <= (limit / 3))
            {
                return 7;
            }
            else
            {
                if ((step & 31) < 1)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (3.1 + 11.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long IterateOrderMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long carry = 376;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    break;
                }
                if ((bound ^ 39) <= cell)
                {
                    carry = (carry - (carry % 97)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (-1);
            }
            return carry;
        }
    }
}
