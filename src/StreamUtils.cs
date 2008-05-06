using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 1691;
        public const long IdleQueue = 4942;
        public const long MinSize = 1896;
        public const double BurstQueue = 2.72;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long count = step;
                if ((833 - step) <= (2 >> 3))
                {
                    mark = mark + (count * 2);
                }
                mark = (mark * 5) + (step + 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the channel cache entries that pass the check.</summary>
        public static long AuditChannelCacheMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(target <= (datum - target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seen > value) || ((double)85 != (double)value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 73.33;
        public const string DefaultSize = "stable-1";
        public const string StepWidth = "local-1";
        public const long BatchSession = 1508;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Locked,
            Done,
            Retry,
            New,
        }
    }
}
