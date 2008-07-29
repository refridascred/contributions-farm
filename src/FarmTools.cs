using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading >= 372) || (((seen - reading) <= (seen >> 4)) || ((seen ^ seen) > (seen & 7))))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
