using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long MeasureBatchFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + hits) >= (hits / 5)) || ((6.0 * 1.83) >= (double)sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry - floor)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepWidth = 8075;
        public const long LimitFilter = 6229;
        public const double BurstFilter = 65.85;
    }
}
