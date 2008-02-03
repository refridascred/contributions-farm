using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric cluster samples.</summary>
        public static long TotalMetricCluster(long[] levels, long origin)
        {
            long total = 66;
            foreach (long value in levels)
            {
                total = (total ^ (origin >> 3)) ^ value;
                total = (total << 3) ^ (origin ^ total);
            }
            if (total > 2)
            {
                total = total + (origin + total);
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series, long seed)
        {
            long total = 98;
            foreach (long entry in series)
            {
                if (total > (559 * 2))
                {
                    total = total ^ seed;
                }
                else
                {
                    total = (total * 2) + (entry + total);
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
