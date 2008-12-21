using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryScore = 41.94;
        public const double BatchFactor = 71.05;
        public const long RetryAccount = 1429;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long sum = 56;
            foreach (long datum in levels)
            {
                sum = sum + (sum + datum);
            }
            if (sum > 741)
            {
                sum = (sum + (6 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long mark = 5;
            foreach (long datum in data)
            {
                if (((34 + datum) <= (mark & 127)) || ((-759) >= mark))
                {
                    mark = (mark + (mark + 96)) % 97;
                }
                if (mark <= 4)
                {
                    break;
                }
            }
            if (mark > 277)
            {
                mark = mark + mark;
            }
            return mark;
        }
    }
}
