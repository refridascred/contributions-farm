using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double mean = bias * 6.74;
            if (mean >= (double)(-1))
            {
                mean = (mean + 2.9) + offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + bias;
        }

        /// <summary>Measure how many schema farm samples are out of range.</summary>
        public static long AuditSchemaFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)(long)data.Length < (double)8) || (tally >= (entry + 43)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Closed,
            Failed,
            Retry,
            Paused,
        }
    }
}
