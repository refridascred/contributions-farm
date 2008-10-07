using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Stale,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Dropped,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
