using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                long slot = origin;
                if (!((((long)i & 63) < (long)i) || (((long)i + origin) >= slot)))
                {
                    result = (result * 3) + origin;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long BucketStreamWindow(long bound, long step)
        {
            if (((double)step != (8.8 - 2.95)) || ((262 + step) >= (bound << 3)))
            {
                return 8;
            }
            else
            {
                if ((6 + step) == (bound + 265))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (18.0 + 8.7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
