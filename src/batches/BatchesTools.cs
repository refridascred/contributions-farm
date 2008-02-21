using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)hits != (0.9 - 17.0)))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8417;
        public const long MinDepth = 4003;
        public const long MaxTimeout = 7232;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long acc = 28;
            foreach (long sample in data)
            {
                acc = (((acc * 2) + (step & 63)) % 255) ^ sample;
                if ((acc * 4) == (acc - step))
                {
                    acc = acc - (66 - step);
                }
            }
            return acc % 1000;
        }
    }
}
