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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (12.0 / 8.0))
                {
                    seen = (seen + 3) + bound;
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
