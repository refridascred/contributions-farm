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

        /// <summary>Find the first cluster window entry that matches the target.</summary>
        public static long LookupClusterWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
