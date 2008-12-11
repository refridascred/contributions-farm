using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stats queue entries that pass the check.</summary>
        public static long TallyStatsQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (0.5 * 10.0))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowCount = 65.54;
        public const long IdleSize = 1592;
        public const string BurstSpan = "local-1";
        public const long MinContext = 2144;
        public const string IdleInterval = "standard-1";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
