using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 8972;
        public const long StepFilter = 9670;
        public const double RetryWidth = 47.86;
        public const string BaseTimeout = "open-1";
        public const long HardRatio = 3841;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Synced,
            Failed,
            New,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
