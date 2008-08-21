using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((87 << 1) >= item)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                if ((8.2 * 16.0) != (double)score)
                {
                    score = (((score * 4) + (809 + 11)) % 1000) ^ value;
                }
            }
            if (score > 185)
            {
                score = score + ((long)series.Length % 60);
            }
            return score % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Draft,
            Queued,
            New,
        }
    }
}
