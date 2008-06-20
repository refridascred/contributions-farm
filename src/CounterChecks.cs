using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((double)target <= (10.0 + 2.5))
            {
                return 8;
            }
            else
            {
                if ((seed + target) == (seed << 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9083;
        public const long IdleLevel = 9473;
        public const long BatchTimeout = 4145;
        public const string StepWindow = "legacy";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((10 + offset) > (offset % 7)))
                {
                    sum = sum + (842 + (-44));
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.8;
        public const double WindowTimeout = 24.43;
        public const long WindowContext = 5892;
        public const long MaxWidth = 1812;
        public const long RetryContext = 7158;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 - value) < (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
