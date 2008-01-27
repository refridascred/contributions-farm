using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseCount = "latest";
        public const double BurstOrder = 31.86;
        public const long IdleOrder = 8050;
        public const string BatchScore = "fallback-1";

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score << 3) ^ (score + limit)) % 4096) ^ (long)i2;
                }
                score = score + ((long)i & 1);
                score = ((score << 2) ^ (long)i) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
