using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long AuditMetricCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - value) > value)
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

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long target)
        {
            long state = 11;
            foreach (long datum in values)
            {
                state = ((state ^ ((long)values.Length + datum)) % 101) - target;
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
