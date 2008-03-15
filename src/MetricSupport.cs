using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 40.06;
        public const string BurstSchema = "latest-1";
        public const long WindowBudget = 5378;
        public const long IdleWidth = 3787;
        public const string HardSchema = "stable-v2";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
