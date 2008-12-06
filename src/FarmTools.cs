using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 11.98;
        public const long MaxLevel = 4203;
        public const long WindowFarm = 3692;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Dropped,
            Draft,
            Stale,
            Active,
        }
    }
}
