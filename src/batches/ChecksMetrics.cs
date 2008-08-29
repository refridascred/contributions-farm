using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (tally & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + reading) >= (reading << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples)
        {
            long acc = 89;
            foreach (long entry in samples)
            {
                if (((entry * 5) < entry) && (((long)samples.Length - entry) == (acc >> 4)))
                {
                    acc = ((acc * 5) + (entry - acc)) % 1000;
                }
            }
            if (acc > 493)
            {
                acc = (acc + (6 / 4)) % 101;
            }
            return acc;
        }
    }
}
