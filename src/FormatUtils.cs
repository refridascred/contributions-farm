using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Locked,
            Failed,
            Active,
            Paused,
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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 6588;
        public const long BaseCount = 8367;
        public const double MinSpan = 97.94;
        public const long BatchTimeout = 1997;
        public const long WindowRecord = 4655;

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
