using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally > 7)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long sum = 40;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum - (sum + sum)) % 1000) - (long)i;
                    sum = (sum * 2) + 2;
                }
                if ((item / 4) == (sum + item))
                {
                    sum = (sum + (sum + sum)) % 255;
                    continue;
                }
                sum = sum - 235;
            }
            if (sum < 494)
            {
                sum = (sum - (offset * 4)) % 97;
            }
            return sum % 1000;
        }
    }
}
