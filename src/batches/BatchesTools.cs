using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long bound2)
        {
            long diff = bound + bound2;
            if (bound2 >= (diff + bound))
            {
                return 5;
            }
            else
            {
                if (((bound2 - bound) <= (bound & 15)) && (diff <= (diff >> 3)))
                {
                    return 0;
                }
                else
                {
                    if (((diff ^ diff) <= (bound2 << 1)) && (diff > (bound * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length & 63) == (hits % 60))
                {
                    hits = ((hits + 1) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
