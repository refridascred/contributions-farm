using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cache context entries.</summary>
        public static long WeighCacheContext(long[] levels, long limit)
        {
            long acc = -350;
            foreach (long datum in levels)
            {
                if (((19 & 3) >= limit) || ((datum + (-869)) <= ((long)levels.Length + 8)))
                {
                    acc = (acc << 2) ^ (datum << 2);
                }
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Digest a series of report graph entries.</summary>
        public static long CombineReportGraph(long[] series, long seed)
        {
            long sum = 45;
            foreach (long sample in series)
            {
                double weight = (double)3;
                if (weight >= (4.2 * 3.16))
                {
                    weight = (weight - weight) + (double)sample;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                sum = (sum + seed) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample ^ hits) > (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
