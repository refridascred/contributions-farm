using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((7.32 - 2.8) < (double)limit)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = acc + 254;
                if ((3 + acc) == (70 - 2))
                {
                    acc = acc ^ (acc + cell);
                }
            }
            return acc % 97;
        }
    }
}
