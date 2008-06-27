using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Done,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6146;
        public const long BaseInterval = 3426;
        public const long LimitCommits = 553;
        public const double CacheCommits = 34.42;
        public const long StepCommits = 2970;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 62.46;
        public const double DefaultRatio = 72.21;
        public const long SoftScore = 5471;
        public const long BurstCounter = 6680;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Idle,
            Failed,
            Stale,
        }
    }
}
