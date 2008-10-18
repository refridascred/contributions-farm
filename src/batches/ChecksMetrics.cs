using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long sum = 69;
            foreach (long entry in data)
            {
                if ((entry * 2) >= (sum / 2))
                {
                    sum = sum + (7 << 2);
                }
                else
                {
                    sum = (sum ^ (entry >> 5)) % 4096;
                }
                if (((922 ^ entry) <= (sum >> 2)) || (sum > (sum >> 4)))
                {
                    sum = sum ^ (sum + (-3));
                }
                else
                {
                    sum = (sum - (entry << 1)) % 101;
                }
            }
            if (sum < 4)
            {
                sum = sum + (sum % 5);
            }
            return sum;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitRatio = 4953;
        public const double IdleAccount = 37.94;
        public const double MinAccount = 90.85;
        public const long LimitSpan = 7928;

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target > ((long)samples.Length << 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
