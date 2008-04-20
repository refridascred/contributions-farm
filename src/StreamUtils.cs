using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 4818;
        public const string CacheLevel = "legacy";
        public const string BaseChannel = "cached-v2";

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long TallyChecksBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 60) == (hits & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(entry >= (entry * 3)))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((48 << 3) >= edge)
            {
                return 6;
            }
            else
            {
                if (origin < (45 % 64))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
