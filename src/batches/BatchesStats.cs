using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 94.58;
        public const long StepCount = 6618;
        public const long MinBudget = 3606;
        public const long WindowCommand = 9276;
        public const long IdleSize = 923;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 1) < 6) && !((2.64 - 7.0) < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSpan = 57.01;
        public const string MaxOrder = "cached-v2";
        public const long MinOrder = 5567;
        public const long HardOrder = 7529;
    }
}
