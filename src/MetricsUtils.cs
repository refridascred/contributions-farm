using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxRatio = 8364;
        public const long MaxSize = 4195;
        public const string CacheInterval = "fallback-v2";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long ClassifyRecordFilter(long offset, long origin)
        {
            long prev = offset - origin;
            if (offset >= (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) <= (origin * 3))
                {
                    return 4;
                }
                else
                {
                    if (!(705 < (prev % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)prev <= (8.0 - 9.53)) && ((double)origin <= (double)3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
