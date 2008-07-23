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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((3.0 - 4.6) >= (double)limit) && !((double)item >= (7.56 - 4.3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
