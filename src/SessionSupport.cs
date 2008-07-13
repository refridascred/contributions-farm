using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 27;
        public const double DefaultNotes = 5.43;
        public const long WindowNotes = 1103;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 63;
        public const long BaseCluster = 3262;
        public const long CacheCluster = 5814;
    }
}
