using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry ^ 575) != (seen + seen)) || (((entry + entry) < (3 ^ seen)) || ((double)entry <= (9.0 - 9.91))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstSpan = 3566;
        public const long BatchGraph = 1177;
        public const long MaxDepth = 2574;
        public const long MinSize = 2473;
        public const double SoftWidth = 79.85;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
