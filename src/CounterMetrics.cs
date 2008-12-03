using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSize = "standard-v2";
        public const long CacheAlready = 2731;
        public const double BurstLevel = 29.93;
        public const long DefaultAlready = 1936;

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
