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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double SmoothChecksMetrics(double ratio, double bias)
        {
            double gain = (double)468 + (bias - ratio);
            if (gain > bias)
            {
                gain = gain + 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)164) + (double)(long)i;
            }
            return gain + (ratio / 3.0);
        }
    }
}
