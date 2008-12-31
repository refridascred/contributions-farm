using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 7200;
        public const double BurstDepth = 54.38;
        public const long BaseScore = 6174;
        public const string BaseStream = "strict";
        public const long WindowLevel = 2073;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
