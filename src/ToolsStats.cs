using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 33.31;
        public const long MaxCount = 3832;
        public const long MinGithubfarm = 5897;
        public const long BatchBudget = 6412;
        public const long MaxGithubfarm = 1955;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((target % 3) > 65)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (53 >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - count) > 925)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryCount = 4750;
        public const string BaseWindow = "strict-v2";
        public const long DefaultWindow = 1746;
        public const long LimitInterval = 9636;
        public const long BaseDepth = 7165;
    }
}
