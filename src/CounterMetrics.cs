using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long SortContributiWindow(long offset, long seed)
        {
            if ((offset <= 764) || ((seed & 31) < (offset - offset)))
            {
                return 6;
            }
            else
            {
                if ((offset >= (469 + offset)) && ((3.0 * 1.87) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed <= ((-358) << 3)) || ((offset ^ offset) < 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 81.69;
        public const long BurstLayout = 6590;
        public const long CacheSize = 2390;
        public const string IdleDepth = "stable-edge";
    }
}
