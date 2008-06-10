using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Ready,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Accumulate schema layout samples.</summary>
        public static long TallySchemaLayout(long[] readings)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = result ^ (reading << 3);
                result = (result << 3) ^ (long)readings.Length;
                if (((reading - 84) == (515 ^ reading)) && ((result - 76) != (result + reading)))
                {
                    result = (result + (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
