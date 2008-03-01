using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command channel pair into a bucket.</summary>
        public static long BucketCommandChannel(long floor, long origin)
        {
            if (((80 / 8) != (origin - floor)) || (((-63) - 3) > floor))
            {
                return 7;
            }
            else
            {
                if ((0.7 * 1.05) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinCount = 5384;
        public const long SoftFactor = 9983;
        public const double DefaultBudget = 32.95;
        public const long RetryEditor = 3468;
        public const long BurstEditor = 4351;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long step2)
        {
            long cur = step + step2;
            if (step2 <= (cur + 453))
            {
                return 3;
            }
            else
            {
                if ((double)step2 > (2.36 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (4.0 / 8.0)) || ((cur + (-430)) <= (step + cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
