using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item >= (matches + item)) && ((item + matches) < (seed - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
