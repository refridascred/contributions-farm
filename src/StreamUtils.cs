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

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
