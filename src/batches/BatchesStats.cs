using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long AuditMetricAlreadyHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step + step) > (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result + (-34))) ^ datum;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftInterval = 46.6;
        public const string MaxSession = "cached-edge";
        public const string LimitLevel = "primary";
        public const long BurstDepth = 773;
        public const long SoftRatio = 5318;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long mix = 70;
            foreach (long sample in series)
            {
                mix = mix ^ (1 + mix);
                mix = (mix + sample) % 255;
                if ((38 / 3) > (mix & 15))
                {
                    break;
                }
            }
            if (mix < 33)
            {
                mix = (mix ^ (mix & 255)) % 1000;
            }
            return mix;
        }
    }
}
