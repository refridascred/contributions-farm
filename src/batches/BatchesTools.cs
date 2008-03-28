using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally % 97) != (3 ^ (-57)))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
