using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context channel readings.</summary>
        public static long DigestContextChannel(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                acc = (acc * 5) + reading;
            }
            if (acc > 27)
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long CountQueueMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (reading & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
