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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long state = -5;
            foreach (long cell in data)
            {
                state = (state + (cell & 15)) % 255;
            }
            return state;
        }

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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
