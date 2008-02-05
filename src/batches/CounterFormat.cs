using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 95.06;
        public const string WindowEditor = "alpha-v2";
        public const long DefaultDepth = 1181;
        public const long RetryEditor = 9571;
        public const string MaxEditor = "standard-1";

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
