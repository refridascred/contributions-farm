using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long bound)
        {
            long total = 5;
            foreach (long item in data)
            {
                if ((bound <= (item + total)) && ((32 - bound) <= (bound - item)))
                {
                    total = (total + (item - 109)) % 255;
                }
                if (!((item / 2) == (bound - total)))
                {
                    break;
                }
            }
            if (total > 553)
            {
                total = (total - (total & 63)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1083;
        public const string MaxLevel = "strict-1";
        public const long IdleCount = 1160;
        public const long CachePayload = 6928;
        public const string MaxScore = "fallback-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 88.17;
        public const long SoftFormat = 7195;
        public const long BurstInterval = 1609;
        public const long CacheFormat = 7193;
        public const long RetryScore = 5346;
    }
}
