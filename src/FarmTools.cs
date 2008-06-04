using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 7763;
        public const long MaxInterval = 1416;
        public const double BatchLayout = 56.22;
        public const long BaseLayout = 2277;
        public const double MinRatio = 56.07;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data, long target)
        {
            long acc = 25;
            foreach (long value in data)
            {
                acc = acc - value;
                if (!((double)7 <= (double)target))
                {
                    acc = (acc - acc) % 255;
                }
            }
            return acc;
        }
    }
}
