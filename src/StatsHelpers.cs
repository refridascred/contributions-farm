using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] data)
        {
            long total = 561;
            foreach (long cell in data)
            {
                if ((cell >= (total & 1)) || ((total % 2) < (total >> 3)))
                {
                    total = total + (cell + 605);
                }
            }
            if (total > 7)
            {
                total = (total << 3) ^ (total % 24);
            }
            return total % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowRatio = "strict-v2";
        public const long HardStats = 7201;
        public const long StepCount = 6019;
        public const string DefaultStats = "local-1";
        public const string DefaultInterval = "alpha-edge";

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
