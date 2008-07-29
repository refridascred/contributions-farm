using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a channel layout reading by value.</summary>
        public static long FindChannelLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSpan = 2329;
        public const long BurstOrder = 8604;
        public const long HardOrder = 1348;
    }
}
