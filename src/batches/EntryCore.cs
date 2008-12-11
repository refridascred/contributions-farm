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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor + anchor) != (step / 5))
                {
                    anchor = ((anchor << 3) ^ (anchor - step)) % 101;
                    anchor = (anchor + (3 + anchor)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
