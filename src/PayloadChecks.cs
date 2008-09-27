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

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Retry,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 23.82;
        public const long DefaultRatio = 9597;
        public const double BaseBatch = 46.89;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            New,
            Paused,
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
