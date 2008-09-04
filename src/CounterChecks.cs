using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Count record format pairs that satisfy a relation.</summary>
        public static long CompareRecordFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch farm readings against a rule.</summary>
        public static long AuditBatchFarmHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.66 + 9.7) < (double)reading)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 91.2;
        public const string LimitContributi = "stable-edge";
        public const long CacheFactor = 9710;
        public const long MaxCount = 6867;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 127) >= ((-873) - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
