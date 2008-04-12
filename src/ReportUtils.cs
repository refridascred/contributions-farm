using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = (total - cell) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] levels)
        {
            long sum = 152;
            foreach (long datum in levels)
            {
                sum = (((sum * 3) + (834 / 4)) % 255) + datum;
                sum = (sum * 5) + 806;
                if ((17.0 + 4.72) < (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
