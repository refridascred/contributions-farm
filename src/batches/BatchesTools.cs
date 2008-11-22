using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long mark = 436;
            foreach (long sample in values)
            {
                mark = (mark ^ mark) ^ sample;
            }
            return mark;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Retry,
        }
    }
}
