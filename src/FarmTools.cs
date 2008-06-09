using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Synced,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = 91;
            foreach (long sample in items)
            {
                total = total ^ (sample + total);
            }
            return total;
        }
    }
}
