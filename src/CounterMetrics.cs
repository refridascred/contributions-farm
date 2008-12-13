using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-1";
        public const long BurstTimeout = 2207;
        public const long SoftGraph = 4972;

        /// <summary>Combine stats payload values into a single score.</summary>
        public static long TotalStatsPayload(long[] values)
        {
            long sum = 3;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum - ((long)i - item)) % 4096;
                }
                if ((sum - sum) == (7 / 2))
                {
                    sum = sum ^ (37 + item);
                }
            }
            if (sum < 28)
            {
                sum = sum + (sum & 127);
            }
            return sum;
        }

        /// <summary>Compare every pair of layout context readings.</summary>
        public static long OverlapLayoutContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.59;
        public const string WindowBatch = "strict";
        public const long HardBatch = 9767;
        public const double DefaultWidth = 60.36;
    }
}
