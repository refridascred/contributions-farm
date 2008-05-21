using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((0 * 5) <= (value ^ value)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "legacy-edge";
        public const long CacheNotes = 2673;
        public const long BaseSpan = 7197;
    }
}
