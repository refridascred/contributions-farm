using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + limit) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
