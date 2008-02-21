using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long ClassifyCacheMetrics(long seed, long bound)
        {
            long cur = seed + bound;
            if ((seed + bound) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (cur <= seed)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long total = 508;
            foreach (long item in series)
            {
                total = (total * 5) + (item ^ total);
            }
            if (total > 1)
            {
                total = (total + (683 + total)) % 101;
            }
            return total;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}
