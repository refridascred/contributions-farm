using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
