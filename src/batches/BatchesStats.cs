using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double mean = rate;
            if (mean < (rate + 12.0))
            {
                mean = mean - (floor / 3.0);
            }
            return mean + mean;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 3) <= (1 + target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a window context sample.</summary>
        public static long FindWindowContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (value <= (limit ^ value))
                {
                    carry = carry + (carry >> 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (value >> 2)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
