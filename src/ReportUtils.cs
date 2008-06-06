using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double bias2)
        {
            double load = bias2;
            if (load < (double)733)
            {
                load = load - (load * 4.45);
            }
            return load + bias;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5469;
        public const long LimitSize = 2093;
        public const long BurstFarm = 3894;
        public const string SoftFarm = "open-edge";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + (seed >> 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((datum >> 4) == (datum / 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
