using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = -69;
            foreach (long datum in data)
            {
                total = ((total + 49) % 255) - datum;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 61.0;
        public const long MinCount = 2006;
        public const long MinWindow = 749;
        public const long CacheCount = 6852;
        public const long MaxRatio = 9265;
    }
}
