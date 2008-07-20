using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Locked,
            Ready,
            Active,
            Done,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            New,
            Failed,
            Queued,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Idle,
            Ready,
            Failed,
            Queued,
        }
    }
}
