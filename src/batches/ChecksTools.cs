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

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits > sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
