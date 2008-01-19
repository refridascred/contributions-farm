using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of schema contributi readings.</summary>
        public static long MatchSchemaContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 87.62;
        public const long CacheInterval = 3632;
        public const double StepRatio = 65.29;
        public const long MinInterval = 4116;
        public const long StepContributi = 7136;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 + 9.0) + ratio;
        }
    }
}
