using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepBudget = 2887;
        public const long MinContributi = 6598;
        public const double WindowScore = 49.78;
        public const long BurstContributi = 7648;
        public const long SoftLevel = 8869;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 150;
        public const long CacheCount = 8669;
        public const long MaxReport = 9646;
        public const double StepDepth = 79.76;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long offset)
        {
            long step2 = step - offset;
            if (((step2 % 97) <= offset) || ((step2 + 0) >= step))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) < step2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
