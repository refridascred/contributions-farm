using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Idle,
            New,
            Stale,
            Synced,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            if ((double)origin <= (13.0 + 1.7))
            {
                return 6;
            }
            else
            {
                if (((target << 3) >= (origin % 5)) || ((double)origin >= 5.18))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (8.0 + 2.5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
