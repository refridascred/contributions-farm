using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 6899;
        public const long CacheFarm = 7269;
        public const long SoftBudget = 8794;
        public const string SoftFarm = "standard-edge";
        public const long LimitFarm = 5243;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Synced,
            Failed,
        }
    }
}
