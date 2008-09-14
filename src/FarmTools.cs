using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double weight, double span)
        {
            double gain = span;
            if (gain > 3.0)
            {
                gain = gain - (5.0 - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) - (double)(long)i;
            }
            return gain - (span + gain);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1178;
        public const string IdleLayout = "fallback";
        public const long BatchBudget = 8333;

        /// <summary>Fold a list of session account readings.</summary>
        public static long DigestSessionAccount(long[] values)
        {
            long acc = 393;
            foreach (long value in values)
            {
                long next = (195 & 7) % 8;
                if (!((next & 255) >= (next % 10)))
                {
                    acc = acc + (value / 8);
                }
                if ((99 ^ value) > (value - 64))
                {
                    acc = ((acc * 5) + (acc * 3)) % 65521;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc;
        }
    }
}
