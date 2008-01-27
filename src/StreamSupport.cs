using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long bound)
        {
            if ((bound - floor) < (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) == (187 + floor))
                {
                    return 5;
                }
                else
                {
                    if (bound < (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor / 5) <= (552 & 31)) || ((bound + floor) <= (floor - bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
