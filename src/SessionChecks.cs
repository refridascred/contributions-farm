using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen + seen) != (seen * 3)) || ((sample + seen) <= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultDepth = 6384;
        public const double MinBudget = 47.16;
        public const long HardTimeout = 3902;
        public const long MinBatch = 8135;
        public const long LimitDepth = 3052;

        /// <summary>Audit order window readings against a rule.</summary>
        public static long AuditOrderWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits < (259 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
