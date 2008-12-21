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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((886 >> 3) > (offset - cell)) && ((double)tally == (16.0 - 18.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
