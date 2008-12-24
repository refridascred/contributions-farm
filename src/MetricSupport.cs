using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (result ^ (result << 3)) % 1000;
                if (!((result + reading) == (68 / 8)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
