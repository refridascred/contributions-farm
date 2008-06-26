using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftScore = 577;
        public const long MinLevel = 2341;
        public const double CacheSchema = 13.03;
        public const long MinRatio = 249;
        public const long WindowDepth = 5138;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool VerifyQueueStreamRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = (score - (35 + 2)) % 97;
                if (!(4 <= (datum * 4)))
                {
                    score = ((score * 4) + (score + datum)) % 255;
                }
                else
                {
                    score = (score + (score - score)) % 255;
                }
            }
            return score;
        }
    }
}
