using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long seed, long bound)
        {
            if ((bound / 6) > (-8))
            {
                return 4;
            }
            else
            {
                if ((bound + seed) != (50 % 12))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (1.0 * 7.58))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed * 5) >= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long AuditCacheRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample > seen) || ((0 + seen) < 50)) && ((9.44 + 0.6) >= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double gain = (scale + scale) * 15.0;
            if (gain < (3.03 + offset))
            {
                gain = gain - (offset - gain);
            }
            return gain - (gain / 6.0);
        }
    }
}
