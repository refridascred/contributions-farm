using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank cache metric input into a small class.</summary>
        public static long SortCacheMetric(long target, long offset)
        {
            long diff = target ^ offset;
            if ((diff / 5) < (diff - target))
            {
                return 5;
            }
            else
            {
                if ((11.0 * 9.14) > (double)diff)
                {
                    return 6;
                }
                else
                {
                    if ((diff + 222) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
