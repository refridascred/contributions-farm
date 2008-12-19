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

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long CountLayoutChannelHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(floor > count) || ((double)floor < (5.1 - 20.0)))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
