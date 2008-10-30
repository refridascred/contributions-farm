using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 9390;
        public const double CacheScore = 30.06;
        public const double MaxChecks = 37.42;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long step)
        {
            long prev = seed ^ step;
            if ((5.0 * 8.46) <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((seed - prev) > (step - prev)) || ((double)35 != (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= 7.05)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 75.3;
        public const long MinScore = 2938;
        public const long DefaultTimeout = 4888;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheWidth = 6550;
        public const long RetryFactor = 5652;
        public const long RetryScore = 5813;
        public const long StepLayout = 4454;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long step, long target)
        {
            if (1 <= (target ^ 32))
            {
                return 4;
            }
            else
            {
                if (!((double)target <= (20.0 - 5.9)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
