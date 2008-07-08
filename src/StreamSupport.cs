using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if ((406 - state) >= cell)
                {
                    state = state + (state << 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((seed >> 2) <= seed)
            {
                return 0;
            }
            else
            {
                if ((delta >> 1) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= 6.0) && ((double)floor > (9.4 - 2.4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Queued,
            Idle,
            Dropped,
            Paused,
        }
    }
}
