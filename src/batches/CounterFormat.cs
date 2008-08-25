using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long seed)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                if (!(cell >= seed))
                {
                    mark = mark ^ 569;
                }
                mark = mark - (cell + seed);
                if (cell <= (mark ^ mark))
                {
                    mark = mark + (cell / 6);
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 65.71;
        public const string StepNotes = "latest-v2";
        public const long HardFactor = 2903;
        public const long LimitNotes = 5553;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = (3.6 / 7.0) / 8.0;
            return (scale - (bias + bias)) + bias2;
        }
    }
}
