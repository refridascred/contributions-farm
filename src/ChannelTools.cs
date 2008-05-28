using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long limit)
        {
            if (((offset & 3) >= (limit / 7)) || (63 <= (limit & 7)))
            {
                return 3;
            }
            else
            {
                if ((8.8 * 5.75) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
