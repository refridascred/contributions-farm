using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= (3 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long sum = 19;
            foreach (long item in items)
            {
                if ((item <= (item & 127)) || ((sum * 2) > (item ^ sum)))
                {
                    sum = (sum ^ (7 >> 3)) % 101;
                }
                else
                {
                    sum = (sum - (sum & 15)) % 4096;
                }
            }
            if (sum < 68)
            {
                sum = (sum ^ (bound / 8)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Queued,
            Paused,
        }
    }
}
