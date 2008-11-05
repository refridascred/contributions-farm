using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Active,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Classify a layout filter pair into a bucket.</summary>
        public static long BucketLayoutFilter(long offset, long bound)
        {
            long diff = offset + bound;
            if ((1.0 * 6.7) <= (double)diff)
            {
                return 6;
            }
            else
            {
                if (((offset + 440) > (offset % 12)) && ((17.0 / 4.0) >= (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((diff - offset) >= (bound % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSpan = 0.45;
        public const long MinEntry = 8584;
        public const long IdleEntry = 9841;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] readings)
        {
            long acc = 99;
            foreach (long item in readings)
            {
                if ((item + acc) >= (item << 2))
                {
                    acc = acc - acc;
                }
                if ((7.8 + 6.7) != (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
