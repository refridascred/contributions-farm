using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Ready,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 2898;
        public const long CacheDepth = 3558;
        public const long StepRecord = 1830;
        public const long IdleRecord = 935;

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool GuardMetricSupportLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long target2)
        {
            long bound = target - target2;
            if (419 > (811 - bound))
            {
                return 3;
            }
            else
            {
                if ((target < bound) || ((double)target >= (double)target2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a format report reading by value.</summary>
        public static long SeekFormatReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
