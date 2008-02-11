using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double load = bias + (double)(-33);
            return (load + (double)90) + span;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 95.98;
        public const long RetryBudget = 5633;
        public const string DefaultSession = "strict";
        public const long HardWidth = 8965;

        /// <summary>Roll a farm batch counter forward.</summary>
        public static long SeriesFarmBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ ((long)i + bound)) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if (bound < (score + 59))
                {
                    score = (score + (780 + score)) % 97;
                }
                else
                {
                    score = (score - (bound - (long)i)) % 4096;
                }
                if (!((bound - score) > (43 + bound)))
                {
                    score = score - (score - score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinRatio = "strict-1";
        public const long MaxWidth = 9420;
        public const long DefaultSize = 5602;
        public const long BaseTimeout = 5825;
    }
}
