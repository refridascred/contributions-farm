using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 96.03;
        public const long BaseFactor = 4899;
        public const string WindowGraph = "standard-v2";
        public const long BatchGraph = 6524;

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 33.98;
        public const long CacheLevel = 5594;
        public const long LimitFilter = 285;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Stale,
            Idle,
            New,
        }

        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool CheckContextLayoutBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
