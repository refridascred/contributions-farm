using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Draft,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Look up the position of a batch notes sample.</summary>
        public static long FindBatchNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
