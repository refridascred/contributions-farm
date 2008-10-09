using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchInterval = 65.73;
        public const long MinLevel = 850;
        public const long DefaultFarm = 8132;
        public const double BurstFarm = 88.06;
    }
}
