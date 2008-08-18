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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Active,
            Pending,
            Ready,
            Stale,
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
