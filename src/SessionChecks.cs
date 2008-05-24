using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length >> 3) != (tally % 16))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits >> 5) != (hits - 993))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
