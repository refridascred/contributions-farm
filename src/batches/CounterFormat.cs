using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine entry metric values into a single score.</summary>
        public static long DigestEntryMetric(long[] values, long bound)
        {
            long sum = 786;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (sum + bound)) + sample;
            }
            return sum % 97;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (double)matches)
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
