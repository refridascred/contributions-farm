using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            if ((double)bound2 > 7.4)
            {
                return 2;
            }
            else
            {
                if (((bound2 + bound2) == (bound + bound2)) || (bound2 < (bound2 + bound2)))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 7) <= bound2) || ((double)bound <= (double)bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
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
