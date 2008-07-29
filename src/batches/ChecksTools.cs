using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long offset)
        {
            long next = bound - offset;
            if (next <= (next - offset))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) <= 9)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((offset + offset) > (offset / 5))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) >= (2 ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((target >> 4) >= (target & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell > (cell >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
