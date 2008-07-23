using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)entry > (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] values, long limit)
        {
            long result = 33;
            foreach (long entry in values)
            {
                if ((entry < limit) && ((double)result > (5.1 - 9.02)))
                {
                    result = (result * 2) + (limit - 33);
                }
            }
            if (result > 231)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data, long bound)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if ((7.03 + 3.85) != (double)bound)
                {
                    result = result + (cell & 63);
                    continue;
                }
                result = ((result * 2) + (cell & 63)) % 65521;
            }
            return result;
        }
    }
}
