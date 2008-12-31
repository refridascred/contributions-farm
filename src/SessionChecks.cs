using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long carry = 19;
            foreach (long item in readings)
            {
                carry = (((carry * 2) + (7 % 5)) % 4096) ^ item;
            }
            return carry % 1000;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Active,
            Pending,
        }
    }
}
