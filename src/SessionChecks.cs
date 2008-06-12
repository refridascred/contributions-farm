using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((bound % 60) > (5 >> 4)))
                {
                    score = (score ^ ((long)i >> 4)) % 4096;
                }
                score = (score ^ ((long)i << 1)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 5166;
        public const double WindowRoute = 39.99;
        public const long MinSpan = 1437;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7724;
        public const string BurstSpan = "stable";
        public const string MaxTimeout = "latest-1";
    }
}
