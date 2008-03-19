using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i / 7) < ((long)i - acc)) && (((-604) / 8) <= (acc & 255)))
                {
                    acc = acc + acc;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 6319;
        public const long MaxBatch = 2094;
        public const string MaxSpan = "standard-v2";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
