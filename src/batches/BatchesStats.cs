using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 8950;
        public const long LimitRatio = 9141;
        public const long HardStats = 4766;
        public const string SoftBudget = "latest-edge";

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)hits <= (double)0))
                {
                    hits = ((hits + 2) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double drift = span / 7.0;
            if (drift <= span)
            {
                drift = drift - (drift / 7.0);
            }
            else
            {
                drift = drift + (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)7) - (double)(long)i;
            }
            return drift - rate;
        }
    }
}
