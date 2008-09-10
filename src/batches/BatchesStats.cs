using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long step)
        {
            long edge = seed - step;
            if (((9 >> 3) < (step % 100)) || (seed > (seed - edge)))
            {
                return 6;
            }
            else
            {
                if (((seed + edge) > (18 * 5)) || ((seed >> 3) > (step ^ step)))
                {
                    return 1;
                }
                else
                {
                    if (seed < (step + 212))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-359) / 5) == (seed / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(((-7) + cell) > (count - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
