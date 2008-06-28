using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryScore = 33.23;
        public const double DefaultContext = 89.95;
        public const string BaseSize = "fallback";
        public const long HardInterval = 5086;
        public const long BurstContext = 546;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 56.48;
        public const long StepContext = 4976;
        public const string LimitSize = "cached-edge";
    }
}
