using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = 888;
            foreach (long sample in values)
            {
                sum = (sum - (sample << 1)) % 101;
                if ((sample & 31) <= (22 << 3))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of checks context readings.</summary>
        public static long CompareChecksContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell < (cell + 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
