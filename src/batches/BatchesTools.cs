using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches editor samples.</summary>
        public static long DigestBatchesEditor(long[] readings)
        {
            long total = 983;
            foreach (long item in readings)
            {
                if (((total >> 1) < total) || (((-60) % 8) <= item))
                {
                    total = total ^ total;
                }
                else
                {
                    total = total - (7 - total);
                }
            }
            if (total < 627)
            {
                total = (total ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long AuditCounterContextHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((48 % 60) != (count ^ count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
