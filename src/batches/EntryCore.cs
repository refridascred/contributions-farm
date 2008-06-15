using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long anchor = -361;
            foreach (long item in levels)
            {
                if (((anchor + (long)levels.Length) != (item >> 2)) && (5.8 > (double)item))
                {
                    anchor = anchor - (anchor >> 5);
                }
                else
                {
                    anchor = ((anchor * 3) + (25 + item)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Classify a cluster token pair into a bucket.</summary>
        public static long ClassifyClusterToken(long bound, long limit)
        {
            if (!(0 >= (bound >> 4)))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= (limit - limit))
                {
                    return 8;
                }
                else
                {
                    if ((bound / 8) >= 56)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "strict-v2";
        public const string BatchCache = "fallback-v2";
        public const string MaxCache = "fallback";
        public const long HardCache = 7226;
        public const long BurstBudget = 8959;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(hits <= (cell - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
