using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc * 5) + (0 + acc)) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if (((-7) + (-82)) >= bound)
            {
                return 6;
            }
            else
            {
                if ((9.0 > (double)seed) && (seed > (seed + 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 86.25;
        public const double MinBudget = 31.2;
        public const double MaxLayout = 47.36;
        public const string IdleLayout = "primary-1";
        public const long CacheLayout = 5608;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((carry >> 1) == (carry % 97)) || (8.7 <= (double)limit))
                {
                    carry = carry - carry;
                }
                carry = (carry - (3 + carry)) % 65521;
                carry = carry + limit;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long DigestBatchEntry(long[] series)
        {
            long state = 41;
            foreach (long cell in series)
            {
                state = (state - cell) % 1000;
            }
            if (state > 316)
            {
                state = (state - (state % 16)) % 65521;
            }
            return state;
        }
    }
}
