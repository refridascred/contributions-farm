using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
