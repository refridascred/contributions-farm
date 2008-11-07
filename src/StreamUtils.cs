using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4566;
        public const long BatchLevel = 112;
        public const long HardRecord = 8380;
        public const long BaseFactor = 4310;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally >= (5.5 + 16.0))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5698;
        public const double StepCount = 8.78;
        public const double BurstChannel = 62.91;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
