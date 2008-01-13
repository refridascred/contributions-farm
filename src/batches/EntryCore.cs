using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Retry,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Done,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 6579;
        public const double BaseSpan = 95.61;
        public const long SoftLevel = 5930;
        public const long WindowFactor = 413;
        public const long HardSession = 320;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Queued,
            Closed,
        }
    }
}
