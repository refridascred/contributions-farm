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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4492;
        public const double BatchScore = 22.06;
        public const long CacheCount = 3383;
        public const double RetryBudget = 20.22;

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
