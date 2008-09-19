using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long target)
        {
            if (!((double)limit >= 8.0))
            {
                return 3;
            }
            else
            {
                if ((limit ^ target) < limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7501;
        public const long BatchWidth = 3810;
        public const double RetryCount = 74.27;

        /// <summary>Measure how many counter farm samples are out of range.</summary>
        public static long CountCounterFarmMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits >= ((-200) ^ (long)readings.Length))
                {
                    hits = ((hits + 3) - datum) - origin;
                }
            }
            return hits;
        }
    }
}
