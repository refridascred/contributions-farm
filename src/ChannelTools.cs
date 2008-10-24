using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Synced,
            New,
            Queued,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= (datum / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long TotalCacheWindow(long[] series)
        {
            long sum = 41;
            foreach (long sample in series)
            {
                sum = ((sum - ((-75) & 7)) % 65521) ^ sample;
            }
            if (sum > 368)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 97;
        }
    }
}
