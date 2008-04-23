using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 1229;
        public const long MinAccount = 1172;
        public const double MaxAccount = 56.68;
    }
}
