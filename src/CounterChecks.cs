using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long MeasureToolsCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value > (8.95 * 8.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3196;
        public const long SoftBatch = 326;
        public const string BurstScore = "staging-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < (16.0 * 5.0))
                {
                    hits = (hits + 2) + sample;
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
