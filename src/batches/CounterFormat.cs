using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + matches) == (sample - 81))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series, long offset)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((offset + 5) >= (value << 2))
                {
                    sum = ((sum << 2) ^ (value / 7)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1362;
        public const long IdleRoute = 9668;
        public const string BaseSize = "alpha-edge";
        public const long WindowDepth = 2122;
        public const double IdleCount = 80.15;
    }
}
