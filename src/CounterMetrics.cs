using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long TallyStreamLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheSize = 55.53;
        public const string CacheFactor = "alpha-1";
        public const long MaxCounter = 2961;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double gain = (span - rate) - span;
            if (gain > (3.54 * 6.83))
            {
                gain = gain - 20.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (double)63;
        }
    }
}
