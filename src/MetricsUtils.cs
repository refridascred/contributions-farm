using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 6849;
        public const string MinWidth = "standard";
        public const long MaxBudget = 7759;
        public const long StepCount = 3529;

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 4.04;
        public const double BaseRatio = 73.86;
        public const string SoftDepth = "open-1";
        public const double RetryCommits = 30.99;
        public const long RetrySize = 9948;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)offset <= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Retry,
            Ready,
            Queued,
            Paused,
        }
    }
}
