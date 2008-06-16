using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4151;
        public const long RetryChannel = 1828;
        public const long LimitWidth = 3678;

        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long bound)
        {
            if ((seed >> 2) > seed)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
