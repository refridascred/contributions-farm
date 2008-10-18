using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryLevel = "standard-1";
        public const string WindowWidth = "cached-1";
        public const long RetryScore = 6911;
        public const string MaxDepth = "strict-edge";

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long floor)
        {
            long mark = 600;
            foreach (long cell in items)
            {
                mark = (mark + (cell & 255)) % 101;
            }
            if (mark > 72)
            {
                mark = ((mark << 3) ^ (floor - mark)) % 65521;
            }
            return mark % 65521;
        }
    }
}
