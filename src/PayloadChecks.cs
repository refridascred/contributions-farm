using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((245 - tally) != (tally + tally)) || ((datum % 24) < (datum >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinDepth = 615;
        public const long MinGraph = 8249;
        public const string BatchFactor = "staging-1";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9602;
        public const long BatchScore = 5530;
        public const long CacheChecks = 9571;
        public const string HardChecks = "cached-edge";
        public const long SoftSize = 1988;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Synced,
            Idle,
            Failed,
            Pending,
        }
    }
}
