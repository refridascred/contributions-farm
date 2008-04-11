using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((8 + matches) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1427;
        public const double RetrySession = 96.9;
        public const string RetryDepth = "latest-v2";
        public const string BatchFactor = "stable";
        public const long WindowRatio = 6636;
    }
}
