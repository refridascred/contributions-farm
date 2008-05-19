using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 7664;
        public const long CacheCount = 1524;
        public const string RetryBatches = "fallback";

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long TallyPayloadCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((3.0 + 20.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long acc = 56;
            foreach (long value in data)
            {
                if (value > (value + (-30)))
                {
                    acc = acc + seed;
                }
                else
                {
                    acc = acc ^ value;
                }
            }
            return acc;
        }
    }
}
