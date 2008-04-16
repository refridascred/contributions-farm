using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Stale,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 83.5;
        public const long BaseRatio = 4791;
        public const long DefaultDepth = 1197;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
