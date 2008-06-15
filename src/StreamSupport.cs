using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Synced,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every tools token entry stays within the limit.</summary>
        public static bool VerifyToolsTokenLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
