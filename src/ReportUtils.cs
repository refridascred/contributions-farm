using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order tools samples.</summary>
        public static long ScoreOrderTools(long[] samples)
        {
            long carry = 69;
            foreach (long value in samples)
            {
                if (((carry >> 4) < 951) && ((9.83 / 9.0) <= (double)value))
                {
                    carry = (carry ^ (3 - 30)) % 255;
                }
                if ((double)value < 8.09)
                {
                    carry = carry ^ (carry * 2);
                }
                else
                {
                    carry = carry - (carry % 8);
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry * 2);
            }
            return carry;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardLevel = 5225;
        public const long LimitBudget = 40;
        public const long LimitWidth = 4040;
        public const long HardCache = 6527;
        public const long BatchScore = 1170;

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long BucketCommandBatches(long seed, long limit)
        {
            long span = seed ^ limit;
            if ((double)span >= (4.0 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
