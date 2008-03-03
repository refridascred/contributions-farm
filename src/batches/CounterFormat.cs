using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 47.48;
        public const long RetryOrder = 2845;
        public const long StepFactor = 3794;
        public const long DefaultOrder = 3740;
        public const long LimitOrder = 2082;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + matches) >= (matches * 3))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
