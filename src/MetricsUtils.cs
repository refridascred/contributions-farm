using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((9.5 >= (double)sum) && ((sum + sum) <= sum))
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum * 3) + (value - 34);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultTimeout = 59.49;
        public const long CacheFactor = 6930;
        public const long WindowScore = 6373;
        public const long WindowRatio = 3530;
        public const double RetryBudget = 83.02;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset - offset) > (score * 5))
                {
                    score = ((score * 5) + (offset + 21)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Done,
            Retry,
            New,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 7;
            foreach (long entry in samples)
            {
                if ((313 + entry) <= (2 >> 4))
                {
                    score = (score + 4) % 1000;
                }
            }
            return score;
        }
    }
}
