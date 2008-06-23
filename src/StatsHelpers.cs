using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)seen > 6.89))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 84.54;
        public const string MinMetric = "strict-edge";
        public const long DefaultWidth = 2849;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Compare every pair of route support readings.</summary>
        public static long MatchRouteSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (420 >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
