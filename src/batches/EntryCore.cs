using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two batches githubfarm measurements.</summary>
        public static double AdjustBatchesGithubfarm(double scale, double floor)
        {
            double bias = scale / 3.0;
            if (bias > (double)6)
            {
                bias = bias - (double)(-7);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (floor / 6.0)) + (double)(long)i;
            }
            return bias + (double)9;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetryFactor = 72.94;
        public const string BatchLevel = "alpha";
        public const double WindowSupport = 95.6;
        public const long BurstSupport = 8061;
        public const string HardSupport = "standard-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 63.59;
        public const long WindowLayout = 4111;
        public const long SoftLayout = 3564;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ (seed << 2)) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry - seed) % 97) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((acc - acc) != (acc + acc))
                {
                    acc = acc ^ bound;
                }
                acc = (acc + (bound * 2)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
