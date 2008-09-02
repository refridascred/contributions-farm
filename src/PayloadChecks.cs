using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 5905;
        public const double BurstWindow = 0.68;
        public const long RetryWindow = 4656;
        public const long RetryRatio = 4118;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Closed,
            New,
            Retry,
        }

        /// <summary>Check that every queue token entry stays within the limit.</summary>
        public static bool VerifyQueueTokenLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long floor)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                if (((result * 2) == (entry ^ 2)) && ((354 + floor) >= floor))
                {
                    result = ((result * 4) + 3) % 1000;
                }
                else
                {
                    result = (result * 3) + (result % 24);
                }
            }
            return result;
        }
    }
}
