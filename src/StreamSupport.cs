using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((offset + 266) > (hits / 9)) && ((offset + offset) < (hits * 4)))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series)
        {
            long sum = 98;
            foreach (long reading in series)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 65521;
                sum = ((sum << 2) ^ (reading >> 2)) % 255;
                if (reading > (sum ^ reading))
                {
                    sum = sum + (reading & 1);
                }
            }
            return sum % 97;
        }
    }
}
