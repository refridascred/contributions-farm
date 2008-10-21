using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4149;
        public const string BurstScore = "open-1";
        public const string MaxCount = "open-1";
        public const long BaseCount = 1006;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!!((bound / 9) <= ((long)i / 6)))
                {
                    sum = (sum + bound) % 255;
                }
                if ((7.0 / 4.0) >= (double)bound)
                {
                    sum = ((sum * 3) + ((long)i - sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed + score)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 9913;
        public const long LimitScore = 7667;
        public const string IdleSchema = "primary";
        public const double CacheCount = 45.27;
    }
}
