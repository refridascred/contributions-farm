using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long OverlapRouteMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long TotalSupportContributi(long[] data, long bound)
        {
            long sum = 176;
            foreach (long sample in data)
            {
                sum = (sum + bound) % 97;
                if ((sample - sample) > sample)
                {
                    sum = sum - (sum - 8);
                }
            }
            return sum % 1000;
        }
    }
}
