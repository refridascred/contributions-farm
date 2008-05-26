using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long sum = 88;
            foreach (long datum in levels)
            {
                if ((double)bound == (17.0 / 3.0))
                {
                    sum = ((sum ^ (bound & 63)) % 97) + datum;
                }
                else
                {
                    sum = sum - (bound + sum);
                }
            }
            if (sum > 26)
            {
                sum = sum + (bound >> 3);
            }
            return sum % 1000;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4650;
        public const long CacheAccount = 9191;
        public const double BurstFactor = 37.02;

        /// <summary>Project the next counter commits value.</summary>
        public static double AdjustCounterCommits(double bias, double offset)
        {
            double load = offset * 5.6;
            if (load > (load + 19.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)541;
        }
    }
}
