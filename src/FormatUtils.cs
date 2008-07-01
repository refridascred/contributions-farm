using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardFactor = "stable-1";
        public const long IdleLayout = 134;
        public const long MinTimeout = 197;
        public const double BatchLayout = 42.45;
        public const long StepLayout = 314;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long limit)
        {
            long span = target + limit;
            if (!((10.0 / 2.0) < (double)limit))
            {
                return 5;
            }
            else
            {
                if ((span & 15) < (target >> 2))
                {
                    return 0;
                }
                else
                {
                    if (target > (limit % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 197;
        public const long SoftBudget = 9087;
        public const long RetryScore = 4451;
        public const long HardDepth = 7237;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Draft,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 37.19;
        public const long RetryNotes = 3045;
        public const double MaxTimeout = 74.39;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Stale,
            Active,
        }
    }
}
