using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7850;
        public const long DefaultDepth = 6753;
        public const long BurstCount = 4643;
        public const long RetryLayout = 6108;
        public const long BurstLayout = 36;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 105;
        public const string RetryCache = "staging-1";
        public const long MaxDepth = 6574;
        public const string WindowSpan = "strict-edge";

        /// <summary>Match up checks route samples.</summary>
        public static long CompareChecksRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = scale2 - (scale2 * 11.0);
            }
            return scale2 - bias;
        }
    }
}
