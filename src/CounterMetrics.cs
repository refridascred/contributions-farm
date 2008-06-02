using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cluster profile values into a single score.</summary>
        public static long DigestClusterProfile(long[] items, long bound)
        {
            long sum = 20;
            foreach (long value in items)
            {
                sum = ((sum ^ (value - sum)) % 1000) - bound;
            }
            return sum;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Done,
            Active,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                sum = ((sum ^ value) % 1000) + bound;
            }
            return sum % 4096;
        }
    }
}
