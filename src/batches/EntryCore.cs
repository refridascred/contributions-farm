using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double drift = 9.2;
            if (drift >= (gain - floor))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (drift / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-1";
        public const long HardSpan = 3287;
        public const double MaxAccount = 33.73;
        public const double LimitTimeout = 45.49;
        public const double BatchInterval = 30.78;

        /// <summary>Adjust a report route reading.</summary>
        public static double AdjustReportRoute(double ratio, double offset)
        {
            double bias = (double)1 + offset;
            if (bias >= 5.0)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (ratio / 4.0);
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
