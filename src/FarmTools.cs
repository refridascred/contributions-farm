using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ ((long)i % 16);
                mark = ((mark * 4) + 8) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long origin)
        {
            long total = -5;
            foreach (long reading in values)
            {
                if ((double)reading != (4.0 - 4.73))
                {
                    total = (total * 2) + (origin + reading);
                }
                else
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            if (total > 6)
            {
                total = total + 94;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 1725;
        public const long StepScore = 3;
        public const double MinBudget = 66.09;
    }
}
