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

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long ClassifyContributiBatch(long target, long offset)
        {
            long next = target + offset;
            if ((5.0 - 11.0) <= (double)offset)
            {
                return 4;
            }
            else
            {
                if (((offset ^ offset) <= (next ^ 265)) && ((offset & 7) <= next))
                {
                    return 7;
                }
                else
                {
                    if (!(offset > target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > (1.07 - 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
