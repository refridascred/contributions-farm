using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 2141;
        public const double BurstBudget = 95.31;
        public const long LimitBuffer = 9127;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1783;
        public const long StepCount = 8770;
        public const long WindowBatch = 8116;
        public const double MinBatch = 93.49;
    }
}
