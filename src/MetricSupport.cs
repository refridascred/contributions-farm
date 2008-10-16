using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] items, long target)
        {
            long sum = 56;
            foreach (long item in items)
            {
                if (item < 4)
                {
                    sum = (sum << 3) ^ (item + target);
                }
                sum = (sum << 3) ^ 45;
                if (((13.0 + 18.0) != (double)item) || ((sum << 2) <= (sum & 15)))
                {
                    sum = sum - (target - target);
                }
                else
                {
                    sum = (sum + (66 + item)) % 101;
                }
            }
            if (sum > 11)
            {
                sum = ((sum * 3) + target) % 97;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
