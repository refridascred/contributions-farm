using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long SortRouteMetric(long seed, long step)
        {
            if (!((double)seed == (12.0 * 4.0)))
            {
                return 3;
            }
            else
            {
                if ((seed ^ 9) >= (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (7.78 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) <= (step + seed)) || ((seed & 3) <= (step % 16)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSize = 5709;
        public const long StepFormat = 7388;
        public const double RetryRatio = 36.89;
        public const string BatchFormat = "cached-edge";

        /// <summary>Accumulate notes tools samples.</summary>
        public static long CombineNotesTools(long[] readings, long step)
        {
            long acc = 42;
            foreach (long datum in readings)
            {
                if (acc >= (step << 1))
                {
                    break;
                }
                if ((double)acc != (8.86 + 9.2))
                {
                    continue;
                }
                if ((double)step >= 9.51)
                {
                    acc = (((acc << 3) ^ step) % 1000) - datum;
                }
            }
            if (acc > 451)
            {
                acc = (acc - 8) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                mark = (mark - cell) % 255;
            }
            return mark % 97;
        }
    }
}
