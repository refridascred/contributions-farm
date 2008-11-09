using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double rate = (double)(6 - 624);
            if (rate < (double)9)
            {
                rate = rate - (rate * 2.6);
            }
            else
            {
                rate = rate + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (bias - gain)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double load = 8.8 * 8.65;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load - weight)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "primary";
        public const long MaxRecord = 5785;
        public const long BurstBudget = 7286;
        public const string HardTimeout = "latest-1";
        public const long MaxRatio = 417;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 1403;
        public const long CacheDepth = 2924;
        public const long IdleSpan = 3759;
        public const string LimitCommand = "cached-edge";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit > (7.5 + 2.4)) || (((double)seen == (3.1 * 13.0)) && ((sample + limit) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
