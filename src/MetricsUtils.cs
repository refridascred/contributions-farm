using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3751;
        public const long BaseSize = 2704;
        public const long SoftRoute = 1376;

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long anchor = -679;
            foreach (long value in readings)
            {
                if ((anchor - origin) >= (anchor + 27))
                {
                    anchor = ((anchor * 4) + (value - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 3) + (32 * 2);
                }
                if ((954 ^ value) > (origin + value))
                {
                    anchor = (anchor * 5) + (anchor - origin);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + ((long)i + seed)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
