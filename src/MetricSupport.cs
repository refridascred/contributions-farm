using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long MeasureCacheAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count / 6) > 69))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long next = seed - floor;
            if ((4.16 / 5.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((134 / 8) >= next)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
