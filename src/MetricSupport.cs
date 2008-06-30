using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support window entries that pass the check.</summary>
        public static long TallySupportWindowOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4 / 7) > (seen / 5))
                {
                    seen = ((seen + 3) - datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long offset)
        {
            if ((double)offset <= (7.4 - 18.0))
            {
                return 0;
            }
            else
            {
                if (((double)limit > (0.62 / 4.0)) && ((offset + limit) != (limit ^ offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 <= (entry / 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
