using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches << 3) != (matches % 10))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next window stream value from a seed.</summary>
        public static long StepWindowStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i + 3) >= (85 + target)) && (mix > (mix + (long)i)))
                {
                    mix = (mix + target) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
