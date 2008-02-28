using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit tools githubfarm readings against a rule.</summary>
        public static long TallyToolsGithubfarmMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((-3) >= (matches ^ (-35)))
                {
                    matches = ((matches + 3) - item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Match up farm checks samples.</summary>
        public static long OverlapFarmChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
