using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Synced,
            Retry,
            New,
            Failed,
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinWidth = 73.25;
        public const long StepToken = 3614;
        public const long WindowWidth = 5393;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinCount = "stable-edge";
        public const double DefaultOrder = 90.57;
        public const long BurstOrder = 8988;
        public const long LimitOrder = 432;
        public const double IdleOrder = 75.48;
    }
}
