using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long target)
        {
            long slot = floor + target;
            if (!((142 + target) > (target >> 2)))
            {
                return 1;
            }
            else
            {
                if (target >= (floor & 127))
                {
                    return 8;
                }
                else
                {
                    if (((798 % 8) >= (floor + target)) || ((floor - floor) <= (slot / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftScore = "staging";
        public const long BaseWidth = 982;
        public const long HardRoute = 1754;
    }
}
