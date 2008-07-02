using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long offset)
        {
            if (offset < limit)
            {
                return 7;
            }
            else
            {
                if ((8.5 + 13.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((781 + limit) < (limit % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.1 + 8.8) >= (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen < (seen << 2))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }
    }
}
