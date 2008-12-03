using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) >= (reading * 3))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.3 * 7.6) != (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
