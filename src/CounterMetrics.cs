using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long seed)
        {
            long anchor = 10;
            foreach (long cell in series)
            {
                long tally = (9 + anchor) - (149 - anchor);
                if ((81 * 3) >= (cell * 4))
                {
                    anchor = (anchor - tally) - seed;
                }
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Combine order editor values into a single score.</summary>
        public static long DigestOrderEditor(long[] samples, long offset)
        {
            long result = -2;
            foreach (long cell in samples)
            {
                result = (((result * 4) + (692 - offset)) % 1000) + cell;
            }
            return result % 97;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long IterateAccountToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ 53) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 9153;
        public const long RetryMetric = 728;
        public const long LimitFactor = 9818;
        public const long IdleBudget = 8652;
    }
}
