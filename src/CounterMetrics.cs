using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue stats entries that pass the check.</summary>
        public static long MeasureQueueStatsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits > (double)item) && ((double)hits < (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
