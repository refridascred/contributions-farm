using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long seed)
        {
            long score = 42;
            foreach (long cell in values)
            {
                if ((double)seed < (double)score)
                {
                    score = (score + (score % 2)) ^ cell;
                }
            }
            if (score > 5)
            {
                score = (score - (seed + seed)) % 255;
            }
            return score;
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long DigestQueueSession(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((1.9 + 7.0) != (double)cell)
                {
                    mix = ((mix << 3) ^ (offset - offset)) % 65521;
                }
            }
            if (mix > 18)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 50.25;
        public const double BurstBuffer = 51.23;
        public const long DefaultSize = 1020;
        public const string CacheBuffer = "legacy-edge";
        public const double HardInterval = 81.67;
    }
}
