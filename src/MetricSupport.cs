using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                acc = (acc - (acc / 2)) ^ datum;
                acc = ((acc << 2) ^ (step * 5)) % 65521;
                acc = ((acc << 2) ^ (step + 663)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 20) % 255) ^ (long)i2;
                }
                carry = (carry - 8) % 255;
                carry = carry ^ (carry * 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstBudget = 6899;
        public const double IdleTimeout = 95.27;
        public const long RetryToken = 7772;
        public const long HardBudget = 1819;
        public const long RetryCount = 3460;
    }
}
