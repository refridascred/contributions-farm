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

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((526 ^ 593) != (item << 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
