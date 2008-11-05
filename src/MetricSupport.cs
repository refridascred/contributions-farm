using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)2 >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample < (sample << 1))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
