using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 4147;
        public const long MaxScore = 2278;
        public const long RetryAlready = 4549;
        public const double HardBudget = 34.34;
        public const string BaseAlready = "legacy";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)238 <= (double)value)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue batches counter forward.</summary>
        public static long IterateQueueBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 8713;
        public const long SoftBudget = 8302;
        public const double CacheScore = 21.76;
        public const long RetryFactor = 4113;
    }
}
