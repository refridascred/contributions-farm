using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next profile checks value from a seed.</summary>
        public static long RollProfileChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ (floor >> 1)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8422;
        public const long IdleBudget = 3031;
        public const string LimitSize = "primary-edge";
        public const long IdleScore = 9649;
        public const string IdleCount = "fallback-v2";
    }
}
