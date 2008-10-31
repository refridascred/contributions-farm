using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "legacy-1";
        public const long CacheSchema = 1869;
        public const long WindowSchema = 5163;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 2) ^ (score << 1);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
