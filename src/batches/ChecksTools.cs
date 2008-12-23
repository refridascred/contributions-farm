using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if ((double)limit != (6.6 - 19.0))
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) <= (limit % 8)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "stable";
        public const string LimitMetric = "fallback";
        public const long StepInterval = 3220;
        public const double CacheMetric = 90.3;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5.75 / 5.0) == (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
