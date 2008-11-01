using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 6297;
        public const double BatchChecks = 0.5;
        public const long BurstChecks = 5869;
    }
}
