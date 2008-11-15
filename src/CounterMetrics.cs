using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metrics githubfarm entry that matches the target.</summary>
        public static long LookupMetricsGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile route value.</summary>
        public static double BlendProfileRoute(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)3)
            {
                mean = mean - (double)91;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (double)981;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally << 2) <= (bound + 6))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Done,
        }
    }
}
