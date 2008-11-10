using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
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
