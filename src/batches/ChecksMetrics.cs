using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long bound)
        {
            if ((offset + 5) <= bound)
            {
                return 1;
            }
            else
            {
                if ((bound % 2) == (offset + offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleRatio = 18.85;
        public const double HardPayload = 58.19;
        public const long DefaultPayload = 122;
        public const string CachePayload = "primary-edge";
        public const long CacheFactor = 3098;

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long carry = 75;
            foreach (long datum in samples)
            {
                carry = (carry ^ (413 + 4)) ^ datum;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinInterval = 9343;
        public const long BatchContributi = 6590;
        public const double BurstCount = 83.92;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
