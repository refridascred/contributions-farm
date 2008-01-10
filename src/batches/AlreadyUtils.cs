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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstBudget = 9636;
        public const long MinInterval = 2729;
        public const long HardSpan = 9022;
        public const long BurstFarm = 3624;

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

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "legacy-edge";
        public const long MinRatio = 8660;
        public const string SoftTools = "stable-edge";
        public const long MaxTools = 643;
        public const long BurstTools = 3905;
    }
}
