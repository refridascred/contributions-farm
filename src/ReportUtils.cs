using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stats support readings against a rule.</summary>
        public static long AuditStatsSupportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)floor >= (10.0 - 9.0)) || (sample < floor))
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

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long seed)
        {
            long span = target + seed;
            if ((span + span) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((15.0 - 7.8) > (double)span)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a metric batch sample.</summary>
        public static long FindMetricBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Idle,
            Dropped,
        }
    }
}
