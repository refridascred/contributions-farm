using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 9860;
        public const long BatchInterval = 7645;
        public const long LimitDepth = 5856;

        /// <summary>Combine profile schema values into a single score.</summary>
        public static long CombineProfileSchema(long[] samples)
        {
            long sum = 16;
            foreach (long item in samples)
            {
                if ((sum << 2) > (sum / 7))
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = -468;
            foreach (long sample in levels)
            {
                anchor = (anchor + (7 + anchor)) ^ sample;
            }
            if (anchor > 72)
            {
                anchor = ((anchor << 3) ^ (anchor + 97)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
