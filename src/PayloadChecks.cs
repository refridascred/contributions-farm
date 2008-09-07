using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - ratio;
            }
            return mean - span;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long sum = 209;
            foreach (long reading in samples)
            {
                if (((sum / 6) <= (reading << 1)) && ((seed + sum) < (sum + reading)))
                {
                    sum = sum - (reading + seed);
                    sum = (sum * 2) + seed;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if ((-322) > (reading ^ reading))
                {
                    sum = (sum * 2) + (1 * 5);
                }
            }
            if (sum > 1)
            {
                sum = (sum + (4 % 7)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 89;
            foreach (long datum in values)
            {
                if ((carry * 5) >= carry)
                {
                    carry = ((carry + (carry % 12)) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
