using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleRatio = 41.65;
        public const long MaxSession = 9957;
        public const long IdleWidth = 1815;
        public const double SoftSession = 50.31;
        public const long BurstSession = 4749;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Look up the position of a profile record sample.</summary>
        public static long SeekProfileRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
