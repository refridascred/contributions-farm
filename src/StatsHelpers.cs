using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySize = 4484;
        public const long MaxGraph = 1153;
        public const long IdleBudget = 7802;
        public const long BurstRatio = 2643;
        public const long SoftGraph = 3819;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double rate = (double)267 - (scale - span);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Count stats order pairs that satisfy a relation.</summary>
        public static long CompareStatsOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
