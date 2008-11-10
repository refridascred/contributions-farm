using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((9.0 - 7.7) <= (double)target)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "standard";
        public const long MaxCounter = 7554;
        public const long StepCounter = 9249;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
