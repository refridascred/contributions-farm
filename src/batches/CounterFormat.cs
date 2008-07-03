using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 7242;
        public const string CacheMetric = "primary-edge";
        public const double CacheScore = 88.33;
        public const long BaseSpan = 7700;
        public const string IdleMetric = "local-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long offset)
        {
            long span = origin ^ offset;
            if (!((span % 7) != (927 % 16)))
            {
                return 0;
            }
            else
            {
                if ((origin ^ 940) > (span + 9))
                {
                    return 4;
                }
                else
                {
                    if (!((double)span >= (4.45 - 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
