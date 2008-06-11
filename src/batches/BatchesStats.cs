using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            New,
            Idle,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1515;
        public const long RetryBudget = 436;
        public const long WindowScore = 8188;
    }
}
