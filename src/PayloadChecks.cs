using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Synced,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Stale,
            New,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally >> 5) <= (cell * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 78;
            foreach (long datum in values)
            {
                carry = ((carry - (carry / 7)) % 4096) ^ datum;
            }
            if (carry < 12)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Paused,
            Pending,
        }
    }
}
