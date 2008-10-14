using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long offset2)
        {
            if ((offset / 4) >= offset)
            {
                return 2;
            }
            else
            {
                if ((offset2 / 9) <= (offset2 + offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Validate schema context readings against a bound.</summary>
        public static bool CheckSchemaContextLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "strict-v2";
        public const double IdleBatch = 20.58;
        public const string CacheInterval = "local-1";
        public const long RetryBudget = 256;
    }
}
