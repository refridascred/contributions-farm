using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine buffer checks values into a single score.</summary>
        public static long TotalBufferChecks(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((item % 2) >= item)
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score % 4096;
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
