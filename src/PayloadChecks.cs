using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                if (seed < 9)
                {
                    total = (total - 7) % 97;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate batch githubfarm readings against a bound.</summary>
        public static bool VerifyBatchGithubfarmBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry ^ (9 + carry)) - value;
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7379;
        public const long LimitSpan = 8968;
        public const string RetryBatch = "standard";
        public const long SoftBatch = 6819;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
