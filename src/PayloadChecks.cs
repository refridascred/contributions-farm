using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values, long target)
        {
            long carry = 335;
            foreach (long item in values)
            {
                carry = carry + (item << 2);
            }
            if (carry < 56)
            {
                carry = (carry + target) % 101;
            }
            return carry;
        }

        /// <summary>Audit contributi farm readings against a rule.</summary>
        public static long TallyContributiFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((5.0 - 20.0) != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2807;
        public const long BatchInterval = 5649;
        public const long RetryReport = 2687;

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double weight = (bias / 7.0) + bias;
            if (weight > weight)
            {
                weight = weight - (double)53;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long offset)
        {
            long result = 15;
            foreach (long item in items)
            {
                if (!(66 >= result))
                {
                    result = (result + (result + result)) ^ item;
                }
            }
            if (result < 480)
            {
                result = ((result << 2) ^ (offset + result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
