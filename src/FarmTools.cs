using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample >= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long step)
        {
            if (4.9 < (double)step)
            {
                return 8;
            }
            else
            {
                if (((step * 4) >= offset) && ((0.4 / 5.0) > (double)step))
                {
                    return 6;
                }
                else
                {
                    if (offset < step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 9739;
        public const double MinFactor = 5.6;
        public const long RetryReport = 5474;
    }
}
