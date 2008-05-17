using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
