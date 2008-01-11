using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((0.5 * 8.8) > (double)bound)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "legacy-v2";
        public const string RetryNotes = "local-edge";
        public const long WindowBudget = 3715;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i > 43) || ((limit & 15) < limit))
                {
                    acc = (acc << 2) ^ (limit + acc);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowLevel = 5042;
        public const long IdleCounter = 100;
        public const long BurstCounter = 2958;
        public const long StepCounter = 3598;
        public const long SoftCounter = 6731;
    }
}
