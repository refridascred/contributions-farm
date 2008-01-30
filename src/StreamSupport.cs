using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            New,
            Ready,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long limit)
        {
            long prev = target + limit;
            if ((target ^ limit) <= target)
            {
                return 6;
            }
            else
            {
                if ((target & 31) >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((9.9 * 6.1) >= (double)limit) || ((prev >> 2) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
