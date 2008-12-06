using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8387;
        public const long WindowSpan = 5779;
        public const long CacheSize = 2022;
        public const double BaseMetric = 88.39;

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchScore = "stable";
        public const double CacheEntry = 73.64;
        public const double HardEntry = 81.43;

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = (total + ((long)i & 127)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long CountGraphBatchesGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9 >> 3) > tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}
