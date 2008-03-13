using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long TotalLayoutChannel(long[] data)
        {
            long anchor = 999;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) % 255) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 51.56;
        public const long BaseBudget = 5956;
        public const string LimitSpan = "staging-v2";
        public const string HardFilter = "staging-v2";
    }
}
