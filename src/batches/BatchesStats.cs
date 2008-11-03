using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order report input into a small class.</summary>
        public static long RankOrderReport(long origin, long bound)
        {
            if ((bound / 4) < (bound % 97))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) >= (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)2;
            }
            return bias + (bias + bias);
        }
    }
}
