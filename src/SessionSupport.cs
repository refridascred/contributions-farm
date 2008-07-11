using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(((cell / 7) == (717 >> 2)) && ((4.97 - 0.36) < (7.1 + 18.0))))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long bound)
        {
            if (295 <= (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((652 < (limit - bound)) && ((double)4 <= (7.78 * 6.92)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) < (30 & 1))
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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
