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

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8437;
        public const string DefaultAccount = "strict";
        public const double LimitAccount = 25.23;
        public const long StepLevel = 955;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ score) % 255;
                if (((long)i & 127) <= origin)
                {
                    score = (score + (906 << 3)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
