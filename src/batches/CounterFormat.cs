using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long step)
        {
            long delta = target + step;
            if ((step + target) > (1 / 3))
            {
                return 1;
            }
            else
            {
                if ((1.8 / 9.0) < (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item < ((-56) / 9))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
