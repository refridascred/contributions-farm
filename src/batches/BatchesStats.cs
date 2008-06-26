using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 313;
            foreach (long item in levels)
            {
                carry = (carry << 2) ^ (item << 3);
            }
            return carry;
        }

        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long IterateCounterBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many schema order samples are out of range.</summary>
        public static long AuditSchemaOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count & 1) != (count + count)) || ((entry + count) < (911 / 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double rate = 9.0;
            if (rate < floor)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
