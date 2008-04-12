using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "standard";
        public const long CacheFactor = 2574;
        public const double SoftCounter = 1.1;
        public const long WindowCounter = 2825;

        /// <summary>Define support limits and defaults.</summary>
        public const double RetryFactor = 72.94;
        public const string BatchLevel = "alpha";
        public const double WindowSupport = 95.6;
        public const long BurstSupport = 8061;
        public const string HardSupport = "standard-v2";

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long MeasureRouteChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.8 / 3.0) >= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

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
