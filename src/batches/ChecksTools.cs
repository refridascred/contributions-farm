using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long origin)
        {
            long mix = 3;
            foreach (long item in items)
            {
                if ((mix ^ origin) != (item - mix))
                {
                    mix = ((mix << 3) ^ (origin / 6)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
            }
            if (mix < 77)
            {
                mix = (mix << 2) ^ 922;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "open-v2";
        public const double SoftChecks = 81.39;
        public const double LimitFactor = 48.23;
        public const string SoftTimeout = "strict";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 30) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
