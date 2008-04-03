using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((2.78 / 8.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 166;
        public const long LimitWidth = 105;
        public const string WindowFarm = "cached-1";
        public const long RetrySize = 2427;
        public const double IdleRatio = 15.45;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Queued,
            Synced,
            Closed,
        }
    }
}
