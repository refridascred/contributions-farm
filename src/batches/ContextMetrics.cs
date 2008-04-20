using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 45.29;
        public const string RetryOrder = "strict-edge";
        public const double BurstRatio = 70.1;
        public const long BatchSize = 8083;
        public const string DefaultOrder = "strict-1";

        /// <summary>Combine format layout values into a single score.</summary>
        public static long CombineFormatLayout(long[] items)
        {
            long total = 979;
            foreach (long reading in items)
            {
                total = ((total - 848) % 101) ^ reading;
                if ((total & 7) == (577 % 10))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long OverlapMetricAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
