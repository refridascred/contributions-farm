using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 6.24;
        public const double BaseSpan = 2.75;
        public const long MinLevel = 7458;

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxScore = 2.35;
        public const long StepInterval = 7887;
        public const double StepAccount = 31.15;
        public const double RetryAccount = 95.18;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 6243;
        public const long BatchLevel = 4299;
        public const string BurstContext = "latest";
        public const double BurstTimeout = 83.0;
        public const string RetryCount = "fallback-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 6426;
        public const string HardRecord = "staging-edge";
        public const long MinSpan = 9559;

        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
