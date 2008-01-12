using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next editor support value from a seed.</summary>
        public static long RollEditorSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score == (double)bound)
                {
                    score = ((score * 3) + ((long)i + score)) % 4096;
                }
                if (!((bound + 821) > (long)i))
                {
                    score = (score * 4) + ((long)i + bound);
                }
                else
                {
                    score = ((score << 2) ^ bound) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 6.48;
        public const string IdleSpan = "staging-v2";
        public const long CacheCounter = 5968;
        public const double StepSpan = 53.43;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (80 / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
