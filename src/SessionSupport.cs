using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long bound2)
        {
            if ((bound2 % 64) <= (bound2 + bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound != (4.6 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (bound < (bound + bound2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6681;
        public const long HardFormat = 7550;
        public const long DefaultDepth = 6003;
    }
}
