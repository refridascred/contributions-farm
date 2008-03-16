using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (tally / 4))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item << 1) < ((long)data.Length + item)) || (((702 + (-1)) > (seen % 60)) && ((seen * 4) != (item / 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (limit <= (hits << 2))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((-4) > entry) || (764 <= (entry - entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
