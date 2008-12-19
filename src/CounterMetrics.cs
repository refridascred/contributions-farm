using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)offset < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchSpan = 4637;
        public const string LimitSpan = "fallback-1";
        public const long CacheBuffer = 9055;
        public const string RetryBuffer = "fallback";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Idle,
            Active,
            Synced,
        }
    }
}
