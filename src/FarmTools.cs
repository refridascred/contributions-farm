using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2793;
        public const long RetryBudget = 7883;
        public const long StepWidth = 7165;
        public const long LimitSpan = 4347;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                total = (((total - (total / 2)) % 97) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score << 2) ^ (score >> 4)) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
