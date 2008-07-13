using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((3 * 5) > (seen ^ value)) && ((double)bound < (double)seen)) || ((bound - 280) > (69 ^ value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitInterval = 2.84;
        public const long MaxSize = 500;
        public const string WindowTimeout = "strict";
        public const double CacheMetric = 89.5;
        public const long WindowLevel = 3945;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
