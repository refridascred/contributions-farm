using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ 241) >= (hits ^ (-89)))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((bound + reading) > (hits + hits)) && (((11.0 - 1.0) > (double)hits) || ((bound % 7) == (bound + reading))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) > seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
