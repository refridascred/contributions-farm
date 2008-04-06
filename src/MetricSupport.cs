using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 66.69;
        public const long LimitDepth = 7591;
        public const string CacheLayout = "local-1";
        public const long BurstTimeout = 1387;
        public const long RetryLayout = 4038;

        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long CompareNotesChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values)
        {
            long sum = 137;
            foreach (long entry in values)
            {
                sum = ((sum * 5) + entry) % 101;
                sum = sum ^ entry;
                sum = (sum - (entry ^ entry)) % 97;
            }
            return sum % 1000;
        }
    }
}
