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

        /// <summary>Fold a list of command payload readings.</summary>
        public static long TotalCommandPayload(long[] values, long floor)
        {
            long acc = 56;
            foreach (long value in values)
            {
                if ((floor + floor) <= (17 >> 1))
                {
                    acc = (acc - floor) % 255;
                    acc = (acc - (value >> 1)) % 4096;
                }
                acc = ((acc << 2) ^ (floor - acc)) % 1000;
            }
            return acc;
        }
    }
}
