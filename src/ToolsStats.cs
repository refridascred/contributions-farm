using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryBudget = 26.8;
        public const long BatchCount = 7713;
        public const long StepCount = 7680;
        public const long BurstMetrics = 9181;
        public const long MaxMetrics = 6734;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next counter layout value.</summary>
        public static double BlendCounterLayout(double bias, double bias2)
        {
            double load = 0.8;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (bias2 / 6.0)) + (double)(long)i) - bias;
            }
            return load + (double)95;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6364;
        public const long MinAlready = 3463;
        public const long LimitAlready = 6137;
        public const string CacheLevel = "fallback";
        public const long HardCount = 4248;

        /// <summary>Measure how many command metrics samples are out of range.</summary>
        public static long TallyCommandMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry != (double)tally) || (((double)tally <= (2.4 * 0.7)) && ((tally * 2) < (entry + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
