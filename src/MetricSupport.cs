using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            long prev = bound + target;
            if (!((bound + bound) != (target + bound)))
            {
                return 8;
            }
            else
            {
                if ((prev << 2) >= (prev - target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
