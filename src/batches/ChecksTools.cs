using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long MeasureChecksBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits * 5) > (reading & 3)) && ((612 << 3) > (990 ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 5218;
        public const string WindowRecord = "staging-v2";
        public const long IdleRecord = 4479;
        public const long LimitBudget = 9316;

        /// <summary>Roll a token already counter forward.</summary>
        public static long DeriveTokenAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
