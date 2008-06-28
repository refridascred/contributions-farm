using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 1813;
        public const long BaseOrder = 2977;
        public const long BurstBudget = 5174;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Ready,
            Paused,
            Synced,
            Dropped,
        }
    }
}
