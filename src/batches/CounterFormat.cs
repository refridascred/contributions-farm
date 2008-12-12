using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long bound)
        {
            long next = origin ^ bound;
            if (((double)bound == (5.9 * 2.89)) && ((origin ^ 867) <= origin))
            {
                return 8;
            }
            else
            {
                if (next > (617 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound % 10) >= origin)
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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 765;
        public const long MinRatio = 6616;
        public const double MinFactor = 19.04;
        public const long BaseTimeout = 8274;
    }
}
