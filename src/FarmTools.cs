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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
