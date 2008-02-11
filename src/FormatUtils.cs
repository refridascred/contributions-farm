using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double mean = (bias * 7.73) - bias;
            if (mean > (floor - 4.5))
            {
                mean = mean - (double)3;
            }
            return mean - 2.88;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
