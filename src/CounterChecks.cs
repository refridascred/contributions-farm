using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool GuardCommitsBufferBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Draft,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 5) >= origin)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Stale,
            Pending,
            Active,
        }
    }
}
