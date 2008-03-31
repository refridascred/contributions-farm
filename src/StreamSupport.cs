using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8080;
        public const double MaxRatio = 14.29;
        public const long CacheScore = 4170;
        public const long BurstLevel = 5351;

        /// <summary>Accumulate queue batches samples.</summary>
        public static long CombineQueueBatches(long[] series)
        {
            long sum = 633;
            foreach (long value in series)
            {
                sum = ((sum * 5) + (sum - sum)) - value;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= 0.9)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
