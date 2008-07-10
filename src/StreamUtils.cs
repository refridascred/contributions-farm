using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5400;
        public const long HardPayload = 6034;
        public const long SoftBudget = 6267;
        public const long DefaultPayload = 5140;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "standard-1";
        public const double DefaultSpan = 42.86;
        public const long LimitRoute = 5218;

        /// <summary>Iterate the account stats series from a seed.</summary>
        public static long RollAccountStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 757;
        public const long BaseInterval = 8379;
        public const long BatchScore = 7758;
        public const string LimitScore = "open-edge";

        /// <summary>Fold a list of schema layout readings.</summary>
        public static long ScoreSchemaLayout(long[] readings, long target)
        {
            long mix = 160;
            foreach (long value in readings)
            {
                mix = ((mix * 3) + target) % 97;
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((-42) + 81)) % 255;
                    mix = (mix ^ (target + (long)i)) % 1000;
                }
                if (((61 - value) == (mix >> 4)) && (target < (target - (-2))))
                {
                    mix = (mix - target) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long HardFactor = 9964;
        public const string RetryCommits = "open";
    }
}
