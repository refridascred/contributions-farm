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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Paused,
            New,
            Queued,
            Done,
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
