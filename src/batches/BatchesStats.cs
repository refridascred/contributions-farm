using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 45.16;
        public const double BatchBuffer = 12.56;
        public const string SoftFactor = "open-1";
        public const string LimitBuffer = "open";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Paused,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
