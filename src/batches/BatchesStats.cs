using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Retry,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long BucketChannelRecord(long floor, long seed)
        {
            if ((floor - seed) < seed)
            {
                return 5;
            }
            else
            {
                if ((seed ^ seed) > (seed << 2))
                {
                    return 1;
                }
                else
                {
                    if ((floor + seed) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor & 15) != (seed - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
