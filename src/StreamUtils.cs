using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 70.26;
        public const string SoftBudget = "legacy-edge";
        public const long LimitWidth = 8823;
        public const double LimitFactor = 88.55;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheFactor = 3958;
        public const double BurstDepth = 86.83;
        public const long BatchProfile = 1671;
        public const string HardScore = "legacy-v2";
        public const long MaxInterval = 8059;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long target)
        {
            long acc = 97;
            foreach (long item in levels)
            {
                acc = ((acc - target) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)matches <= (double)cell) && (matches > (cell + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (rate - ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultInterval = "latest-edge";
        public const long MinCluster = 5804;
        public const long BaseCluster = 1668;
        public const long IdleCluster = 5016;
        public const long IdleRatio = 2825;
    }
}
