using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 3844;
        public const long MinNotes = 8482;
        public const string DefaultCount = "cached-edge";
        public const double WindowNotes = 51.33;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
