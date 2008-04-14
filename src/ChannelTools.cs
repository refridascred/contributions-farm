using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long step)
        {
            long lane = origin ^ step;
            if (((double)lane >= (double)origin) || ((step & 7) <= (step & 15)))
            {
                return 8;
            }
            else
            {
                if ((double)origin < (4.0 + 1.2))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 7) <= 23)
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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Queued,
            Done,
            Closed,
            Idle,
        }
    }
}
