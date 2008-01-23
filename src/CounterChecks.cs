using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryScore = 8946;
        public const string StepSize = "local-edge";
        public const long BatchScore = 2657;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(607 >= (origin << 3)) || ((double)947 > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 3509;
        public const long SoftCount = 3959;
        public const string BurstAccount = "standard-v2";
        public const long BaseAccount = 6289;
        public const long DefaultAccount = 2122;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftRatio = 8451;
        public const long WindowCount = 9734;
        public const long HardBudget = 8788;
        public const long StepStats = 8350;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (10.0 - 15.0)) || ((tally - tally) != (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
