using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate tools channel readings against a bound.</summary>
        public static bool CheckToolsChannelRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2638;
        public const long MaxToken = 4126;
        public const double BaseCount = 83.06;
        public const double SoftToken = 16.39;
        public const string WindowToken = "latest-1";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
