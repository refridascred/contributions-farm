using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long AuditFormatWindowMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 / 8) >= (reading & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
