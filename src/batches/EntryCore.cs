using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = (bias * 4.1) + 19.0;
            if (load <= (double)227)
            {
                load = load + (double)737;
            }
            else
            {
                load = load - (bias2 * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 10.0) + (double)(long)i;
            }
            return load + (14.0 + bias2);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4001;
        public const long SoftRoute = 1485;
        public const long HardRoute = 4782;
        public const long LimitRoute = 9968;
        public const long MaxTimeout = 5874;
    }
}
