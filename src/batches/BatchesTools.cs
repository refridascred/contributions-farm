using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile layout entries.</summary>
        public static long DigestProfileLayout(long[] series)
        {
            long sum = 95;
            foreach (long reading in series)
            {
                sum = (sum ^ ((long)series.Length + reading)) % 1000;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9305;
        public const string BaseInterval = "local-edge";
        public const string BurstBatches = "legacy";
        public const long DefaultBatches = 8771;
        public const long RetryBudget = 523;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
