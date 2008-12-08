using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long target)
        {
            long slot = offset ^ target;
            if ((slot / 4) == (slot % 7))
            {
                return 4;
            }
            else
            {
                if ((target / 8) >= (offset % 8))
                {
                    return 2;
                }
                else
                {
                    if (20.0 < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot >= (10.0 * 1.69))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Locked,
            Dropped,
        }
    }
}
