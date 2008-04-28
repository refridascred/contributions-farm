using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 3858;
        public const string BatchScore = "primary-edge";
        public const long WindowTimeout = 2676;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a session record counter forward.</summary>
        public static long IterateSessionRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (floor + (long)i)) % 1000;
                mix = mix + ((long)i >> 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 9639;
        public const long RetryDepth = 6686;
        public const double BatchSupport = 51.88;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 74;
            foreach (long value in values)
            {
                score = (score + (value * 5)) % 1000;
            }
            return score;
        }
    }
}
