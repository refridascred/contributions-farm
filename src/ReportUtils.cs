using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Paused,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 9691;
        public const string WindowOrder = "cached-edge";
        public const long CacheDepth = 9094;
        public const long CacheOrder = 2513;
    }
}
