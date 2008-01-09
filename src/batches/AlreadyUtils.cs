using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardFactor = "latest-edge";
        public const long RetryRatio = 7567;
        public const double LimitNotes = 59.45;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if ((floor + origin) <= (7 - 153))
            {
                return 8;
            }
            else
            {
                if ((17 * 2) > (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < (origin & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
