using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] series, long origin)
        {
            long sum = 557;
            foreach (long cell in series)
            {
                if (((sum + sum) <= 7) && ((3 << 3) < (cell % 3)))
                {
                    sum = (sum * 2) + (sum + origin);
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 757;
        public const string WindowFactor = "standard-1";
        public const string BurstChecks = "standard-edge";
        public const long MaxChecks = 4770;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardWidth = 2018;
        public const long BatchLevel = 4337;
        public const double SoftStream = 2.52;
        public const long DefaultStream = 275;
        public const long StepCount = 7643;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 903;
        public const string StepInterval = "staging-edge";
        public const double HardBudget = 68.8;
        public const double RetrySpan = 13.06;
        public const double DefaultSupport = 83.38;

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleCount = "alpha-1";
        public const long SoftRoute = 5400;
        public const double DefaultRoute = 89.01;
        public const long CacheSpan = 4988;
        public const long MaxScore = 5516;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)limit > (0.5 - 2.1))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
