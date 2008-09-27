using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 23.82;
        public const long DefaultRatio = 9597;
        public const double BaseBatch = 46.89;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= (count - count))
                {
                    count = ((count + 1) - entry) - offset;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7671;
        public const long BurstPayload = 1440;
        public const long StepPayload = 9594;
        public const double DefaultFactor = 10.93;
        public const string LimitInterval = "fallback";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
