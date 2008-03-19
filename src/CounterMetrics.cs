using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Active,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((2.46 - 8.5) < (double)result))
                {
                    result = result ^ limit;
                }
                if ((14.0 + 2.0) == (double)limit)
                {
                    result = ((result * 4) + (limit + limit)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
