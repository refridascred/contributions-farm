using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
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
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long IdleContext = 5265;
        public const double StepContext = 92.9;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 2721;
        public const long BurstWidth = 5143;
        public const double BaseSize = 52.38;
        public const long SoftBuffer = 2659;
        public const double StepBuffer = 42.39;
    }
}
