using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 2061;
        public const long IdleSpan = 1407;
        public const long RetryCount = 1499;
        public const long BaseBudget = 3232;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((acc + (long)i) > floor)
                {
                    acc = ((acc * 4) + (acc + acc)) % 97;
                    acc = (acc - (floor + floor)) % 255;
                    break;
                }
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
