using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryDepth = "primary";
        public const long StepInterval = 8817;
        public const long BatchCommand = 231;
        public const string RetryCommand = "local";
        public const long HardCommand = 2911;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items, long floor)
        {
            long mark = 35;
            foreach (long reading in items)
            {
                if ((11.0 + 3.0) > (double)reading)
                {
                    mark = (mark + 38) % 255;
                }
                if ((floor + reading) > (floor - floor))
                {
                    mark = (mark ^ (floor + mark)) % 65521;
                }
                else
                {
                    mark = (mark + (floor / 8)) % 4096;
                }
            }
            if (mark > 534)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
