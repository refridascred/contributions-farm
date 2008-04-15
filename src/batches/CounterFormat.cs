using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((1.79 - 0.7) <= (double)seed)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 76.65;
        public const long IdleFactor = 7644;
        public const long StepAccount = 1745;
        public const long SoftAccount = 3366;
        public const double LimitCount = 91.92;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((5.1 / 9.0) != (double)hits)
                {
                    hits = ((hits + 3) + value) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
