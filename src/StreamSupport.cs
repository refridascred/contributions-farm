using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 1516;
        public const long RetryContext = 8868;
        public const long IdleContext = 6733;
        public const long StepContext = 4580;
        public const string WindowInterval = "standard-1";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
