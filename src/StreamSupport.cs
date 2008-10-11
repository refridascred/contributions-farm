using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ (score * 2)) % 101;
                if ((origin < (246 / 3)) && ((score % 64) > datum))
                {
                    score = (score * 3) + ((long)series.Length & 7);
                }
                else
                {
                    score = score - (origin / 3);
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2976;
        public const long BatchLevel = 7744;
        public const string WindowLevel = "latest";
        public const long LimitMetrics = 1182;
        public const double CacheInterval = 56.12;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if ((sample + sample) > anchor)
                {
                    anchor = ((anchor ^ sample) % 4096) - bound;
                }
            }
            return anchor;
        }
    }
}
