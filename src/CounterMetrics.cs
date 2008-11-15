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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (result >= (long)i)
                {
                    result = (result * 5) + (seed / 7);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
