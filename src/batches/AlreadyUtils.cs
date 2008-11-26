using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryTimeout = 9643;
        public const long BaseStream = 5147;
        public const long StepStream = 1111;
        public const string LimitCount = "legacy";
        public const double WindowStream = 42.02;

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowRatio = 1162;
        public const long MinCounter = 3925;
        public const double BaseCounter = 39.84;

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (offset <= (8 / 9))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
