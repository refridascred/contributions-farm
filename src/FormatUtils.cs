using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long carry = 818;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading >> 4)) % 97;
                if (carry < ((long)readings.Length + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Stale,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Active,
            Pending,
            Draft,
        }
    }
}
