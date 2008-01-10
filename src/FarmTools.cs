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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                long edge = (offset ^ offset) * 4;
                if (((sum & 63) < ((long)i - edge)) && ((3.6 * 19.0) >= (double)offset))
                {
                    sum = (sum * 5) + (sum / 6);
                }
                else
                {
                    sum = (sum - (offset * 5)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
