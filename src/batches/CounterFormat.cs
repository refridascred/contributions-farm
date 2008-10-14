using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series, long seed)
        {
            long total = -798;
            foreach (long sample in series)
            {
                total = ((total ^ seed) % 65521) ^ sample;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= 6)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 95.63;
        public const long BurstSpan = 7578;
        public const string MaxBuffer = "strict-v2";
    }
}
