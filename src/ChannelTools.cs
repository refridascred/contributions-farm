using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a counter batch value against two limits.</summary>
        public static long ClassifyCounterBatch(long target, long floor)
        {
            long step = target ^ floor;
            if (((step + step) > (floor + floor)) || ((target * 2) < (floor % 24)))
            {
                return 2;
            }
            else
            {
                if (((7.9 * 16.0) != (double)target) || (687 > (floor % 60)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
