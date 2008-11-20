using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)7) - (double)(long)i;
            }
            return rate - (bias + rate);
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Retry,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long TallyFormatEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (cell - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Done,
            Queued,
            Idle,
            Closed,
        }
    }
}
