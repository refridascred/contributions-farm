using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Draft,
            Pending,
            Done,
            Active,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Derive the next record batch value from a seed.</summary>
        public static long DeriveRecordBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((4.31 - 6.0) > (double)(long)i)
                {
                    result = (result + (19 >> 2)) % 1000;
                    result = (result - offset) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
