using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchSize = "legacy-1";
        public const long BaseToken = 6457;
        public const long MinSpan = 5657;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5858;
        public const long BurstSize = 3178;
        public const double IdleEditor = 41.32;
        public const long MinTimeout = 5428;

        /// <summary>Rank counter token input into a small class.</summary>
        public static long RankCounterToken(long bound, long offset)
        {
            long edge = bound - offset;
            if ((double)bound < (1.06 * 8.0))
            {
                return 6;
            }
            else
            {
                if ((offset / 5) <= (68 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((edge / 2) < (bound + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
