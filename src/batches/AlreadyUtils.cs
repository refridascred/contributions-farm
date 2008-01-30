using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data, long limit)
        {
            long total = 90;
            foreach (long item in data)
            {
                total = ((total ^ limit) % 65521) - item;
                total = (total ^ total) % 65521;
                total = (total * 5) + (total - limit);
            }
            if (total > 893)
            {
                total = total + (limit + limit);
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches ^ origin) <= (5 >> 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Validate checks entry readings against a bound.</summary>
        public static bool VerifyChecksEntryLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double gain, double span)
        {
            double scale = gain * 4.0;
            if (scale >= (gain + scale))
            {
                scale = scale - (double)196;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - span)) + (double)(long)i;
            }
            return scale - (gain * 3.0);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
