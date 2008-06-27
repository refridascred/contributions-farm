using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 - item) < (item - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry stats readings.</summary>
        public static long WeighEntryStats(long[] data)
        {
            long mix = 40;
            foreach (long item in data)
            {
                mix = (mix * 4) + item;
            }
            if (mix > 372)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Validate layout commits readings against a bound.</summary>
        public static bool VerifyLayoutCommitsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of farm cache readings.</summary>
        public static long MatchFarmCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
