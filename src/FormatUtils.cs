using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8925;
        public const long RetryLevel = 221;
        public const long BaseSize = 2032;

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 62.4;
        public const long MaxDepth = 9674;
        public const double WindowScore = 27.93;
        public const long LimitDepth = 6244;

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 8376;
        public const double RetryRoute = 20.57;
        public const long DefaultRoute = 1493;
        public const long BaseCount = 7484;

        /// <summary>Digest a series of commits layout entries.</summary>
        public static long WeighCommitsLayout(long[] levels)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                if ((double)total > 0.2)
                {
                    total = (total * 4) + (total << 3);
                }
                else
                {
                    total = total ^ (datum + total);
                }
            }
            if (total > 0)
            {
                total = ((total * 2) + (total & 15)) % 255;
            }
            return total;
        }
    }
}
