using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every contributi cache entry stays within the limit.</summary>
        public static bool GuardContributiCacheLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] series)
        {
            long mix = 936;
            foreach (long item in series)
            {
                mix = (mix * 5) + mix;
                if (item <= (559 / 6))
                {
                    mix = (mix - (mix - item)) % 101;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix / 2)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
