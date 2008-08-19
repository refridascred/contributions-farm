using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                sum = ((sum ^ (cell >> 5)) % 1000) - origin;
            }
            return sum;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 78.76;
        public const double BatchStats = 15.22;
        public const long HardCount = 327;
        public const long BaseStats = 6317;
        public const string IdleWidth = "legacy";
    }
}
