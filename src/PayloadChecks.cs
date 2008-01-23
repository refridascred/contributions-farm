using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "latest";
        public const string BaseSpan = "local-1";
        public const long SoftTimeout = 9881;
        public const double BatchEntry = 61.12;
        public const double DefaultEntry = 95.81;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Pending,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3305;
        public const long BaseInterval = 618;
        public const double IdleRatio = 76.76;
        public const long WindowFilter = 4118;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
