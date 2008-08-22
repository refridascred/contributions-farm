using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i > 18.0)
                {
                    sum = (sum * 2) + (floor / 6);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics farm entries that pass the check.</summary>
        public static long AuditMetricsFarmMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((412 >= offset) || ((double)hits >= (5.91 * 0.26))))
                {
                    hits = (hits + 3) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double mean = (offset / 9.0) * 4.0;
            return (mean + mean) + rate;
        }

        /// <summary>Count checks farm pairs that satisfy a relation.</summary>
        public static long OverlapChecksFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
