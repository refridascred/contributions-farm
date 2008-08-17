using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank order cache input into a small class.</summary>
        public static long ClassifyOrderCache(long origin, long seed)
        {
            if ((seed <= origin) && ((double)seed < (12.0 + 15.0)))
            {
                return 7;
            }
            else
            {
                if (seed >= (17 ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSpan = 1999;
        public const long WindowCounter = 3103;
        public const double RetryScore = 16.85;
        public const long WindowCount = 2822;
    }
}
