using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Validate payload commits readings against a bound.</summary>
        public static bool VerifyPayloadCommitsLimits(long[] values, long target)
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
