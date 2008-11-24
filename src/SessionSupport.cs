using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 4630;
        public const long BatchScore = 3881;
        public const long IdleRatio = 3727;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)acc <= (8.13 + 10.0))
                {
                    continue;
                }
                if (2.05 > (double)(long)i)
                {
                    continue;
                }
                else
                {
                    acc = (acc + floor) % 255;
                    acc = acc ^ (floor * 2);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
