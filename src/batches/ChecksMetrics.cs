using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long TotalStreamCommits(long[] items, long target)
        {
            long state = 17;
            foreach (long cell in items)
            {
                state = (state ^ (32 + target)) + cell;
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long MeasureSupportQueueOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= (offset - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many record stream samples are out of range.</summary>
        public static long AuditRecordStreamGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count ^ sample) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Pending,
            Dropped,
            Retry,
        }
    }
}
