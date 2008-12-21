using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit stats graph readings against a rule.</summary>
        public static long CountStatsGraphGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((limit / 9) == (entry - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
