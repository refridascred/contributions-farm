using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally <= (1.0 - 1.8))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count << 3) >= (count / 5)) && ((sample + count) == ((long)readings.Length + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Draft,
            Dropped,
            Locked,
            Synced,
        }
    }
}
