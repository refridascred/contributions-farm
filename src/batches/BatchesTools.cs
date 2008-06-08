using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 9592;
        public const long CacheCluster = 2381;
        public const double MinCluster = 29.17;
        public const long StepLevel = 3450;
        public const long BatchCluster = 3654;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((5.06 * 2.0) != (double)hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
