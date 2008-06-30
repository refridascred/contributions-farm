using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings)
        {
            long mark = 712;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ (long)i) % 97;
                }
                if (datum <= (mark & 7))
                {
                    mark = ((mark * 3) + (mark + datum)) % 97;
                }
            }
            if (mark < (-22))
            {
                mark = (mark << 3) ^ (mark - (long)readings.Length);
            }
            return mark % 4096;
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
