using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count ^ (-450)) >= limit))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
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
