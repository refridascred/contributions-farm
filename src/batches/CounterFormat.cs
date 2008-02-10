using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] values)
        {
            long acc = 71;
            foreach (long sample in values)
            {
                if ((double)acc > (7.4 + 0.1))
                {
                    acc = (acc - (acc - acc)) % 101;
                }
                if ((sample << 3) != (long)values.Length)
                {
                    break;
                }
            }
            if (acc > 27)
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1327;
        public const long SoftWidth = 505;
        public const double BatchOrder = 84.05;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
