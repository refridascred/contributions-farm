using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches stream readings.</summary>
        public static long MatchBatchesStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long limit)
        {
            long result = 784;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)result)
                {
                    result = result - (limit & 3);
                }
            }
            return result;
        }

        /// <summary>Grade a report farm value against two limits.</summary>
        public static long GradeReportFarm(long offset, long target)
        {
            long cur = offset - target;
            if (cur < target)
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long TallyEntryFarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length == (target << 1)) && !((matches >> 2) > matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
