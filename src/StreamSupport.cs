using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8776;
        public const long BatchStats = 9908;
        public const long MinSpan = 4873;
        public const long CacheStats = 8705;
        public const long WindowSize = 7704;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long limit, long step)
        {
            if (((limit ^ step) <= (0 - limit)) || ((double)step != (double)23))
            {
                return 2;
            }
            else
            {
                if (step > (limit / 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
