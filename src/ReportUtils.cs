using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long anchor = 467;
            foreach (long value in readings)
            {
                if (((anchor * 2) >= (anchor >> 5)) || ((value + value) == (8 & 63)))
                {
                    anchor = ((anchor * 3) + value) % 4096;
                }
            }
            if (anchor < 766)
            {
                anchor = (anchor - (anchor * 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long target2)
        {
            if ((target2 + 7) > target)
            {
                return 4;
            }
            else
            {
                if ((target + 2) <= (target2 - target))
                {
                    return 6;
                }
                else
                {
                    if ((86 - 121) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-9) > target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Failed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 9691;
        public const string WindowOrder = "cached-edge";
        public const long CacheDepth = 9094;
        public const long CacheOrder = 2513;
    }
}
