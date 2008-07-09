using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            Idle,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Paused,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
