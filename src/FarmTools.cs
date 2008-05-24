using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6933;
        public const long StepCache = 9415;
        public const long CacheRatio = 7691;
        public const long WindowLevel = 5538;
        public const long BaseCache = 5467;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long step)
        {
            if ((double)step > 5.0)
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > step)
                {
                    return 4;
                }
                else
                {
                    if (((471 << 2) < (bound * 3)) || ((1.4 - 7.72) < (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound <= (7.9 + 7.97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
