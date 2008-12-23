using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + matches) <= (80 & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8680;
        public const string DefaultProfile = "local";
        public const long DefaultLevel = 9500;
        public const long HardProfile = 7556;

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
