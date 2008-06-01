using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long anchor = 66;
            foreach (long item in items)
            {
                if (!((double)target <= (9.73 * 15.0)))
                {
                    anchor = (anchor << 3) ^ (anchor + 156);
                }
                else
                {
                    anchor = (anchor - (item >> 2)) % 101;
                }
            }
            return anchor;
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
