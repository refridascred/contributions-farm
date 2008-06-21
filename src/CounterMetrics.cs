using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next cluster farm value.</summary>
        public static double ScaleClusterFarm(double bias, double bias2)
        {
            double drift = (double)(242 + 353);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift + drift) + (double)(long)i) + bias) - bias2;
            }
            return drift - (drift - drift);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 28.38;
        public const long WindowBudget = 3022;
        public const double BatchReport = 84.23;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((long)series.Length > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
