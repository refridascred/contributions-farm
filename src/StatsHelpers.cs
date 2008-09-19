using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (10.0 + 1.34))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) <= (datum << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up context cluster samples.</summary>
        public static long MatchContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "staging-v2";
        public const long RetrySpan = 7968;
        public const string LimitBatches = "standard-v2";
        public const long StepBudget = 6528;
        public const long BaseBatches = 2783;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long offset)
        {
            if ((limit / 5) < (limit << 2))
            {
                return 0;
            }
            else
            {
                if (limit >= (limit << 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
