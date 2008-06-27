using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a notes metric reading by value.</summary>
        public static long SeekNotesMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long target)
        {
            long mix = 0;
            foreach (long value in data)
            {
                mix = (mix - (value + target)) % 4096;
            }
            return mix;
        }

        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long AuditContributiMetricMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) < ((long)levels.Length + (-5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Pending,
            Retry,
            Locked,
        }
    }
}
