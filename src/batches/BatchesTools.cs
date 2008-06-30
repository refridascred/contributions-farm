using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((acc & 31) < (acc - floor)) && ((double)415 <= (double)acc))
                {
                    acc = acc + floor;
                }
                acc = (acc << 2) ^ (acc % 3);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many profile metric samples are out of range.</summary>
        public static long CountProfileMetricHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + origin) != (long)values.Length)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
