using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long IdleFilter = 869;
        public const double MinFilter = 35.38;
        public const string MaxFilter = "primary-edge";
        public const double MaxScore = 83.11;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long seed2)
        {
            if ((2.43 / 6.0) != (double)seed2)
            {
                return 6;
            }
            else
            {
                if ((double)981 < 1.14)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] items, long limit)
        {
            long total = 76;
            foreach (long reading in items)
            {
                if (((long)items.Length ^ 592) != (total / 8))
                {
                    total = ((total - (total << 2)) ^ reading) + limit;
                }
            }
            return total % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (limit % 60)) % 65521;
                long next = (long)i + (score * 2);
                if (!((limit - next) >= next))
                {
                    next = (next ^ ((-2) >> 3)) % 255;
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
