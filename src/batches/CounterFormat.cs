using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchLevel = 6141;
        public const double RetryPayload = 62.87;
        public const double MinTimeout = 86.13;
        public const long BatchDepth = 8486;
        public const long LimitLevel = 1284;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
