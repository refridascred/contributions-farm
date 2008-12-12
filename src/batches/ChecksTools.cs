using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((96 < (count + target)) || ((double)count != (4.0 - 6.0))) || !((double)sample <= (16.0 * 2.2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long BurstCount = 125;
        public const long DefaultContext = 3678;
        public const double BaseSpan = 16.6;
    }
}
