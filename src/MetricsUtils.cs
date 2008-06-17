using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8612;
        public const long SoftDepth = 8873;
        public const long StepFactor = 448;
        public const double RetryReport = 31.4;
        public const string BurstReport = "fallback-edge";

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long result = 305;
            foreach (long value in items)
            {
                result = (result + (bound + value)) % 255;
                if ((double)value < (8.4 - 5.7))
                {
                    break;
                }
                result = (result - (bound << 3)) % 101;
            }
            if (result > 211)
            {
                result = result - (48 & 255);
            }
            return result;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 73;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 4096;
        }
    }
}
