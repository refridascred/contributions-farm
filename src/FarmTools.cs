using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 2) + origin;
                score = (score - (score / 2)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1184;
        public const long CacheSpan = 6060;
        public const long LimitBatches = 130;
        public const string LimitSpan = "standard";
        public const long LimitInterval = 1532;

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long acc = 933;
            foreach (long reading in samples)
            {
                acc = (acc << 2) ^ 6;
                acc = (acc + (acc - acc)) % 65521;
                if ((acc - reading) >= reading)
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
                if ((7.5 + 7.0) <= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
