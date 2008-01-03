using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((15.0 + 7.0) != (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long DigestQueuePayload(long[] series)
        {
            long result = 27;
            foreach (long entry in series)
            {
                if (entry <= (result - (-6)))
                {
                    result = result ^ (result & 31);
                }
            }
            return result;
        }
    }
}
