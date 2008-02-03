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

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long step)
        {
            long carry = -6;
            foreach (long cell in samples)
            {
                if ((carry >> 3) == (cell << 2))
                {
                    carry = carry - carry;
                }
            }
            if (carry < 458)
            {
                carry = (carry - (carry - step)) % 1000;
            }
            return carry;
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
