using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardSpan = "stable-v2";
        public const long StepSpan = 9838;
        public const long BurstEntry = 9532;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Closed,
            Failed,
            New,
        }

        /// <summary>Blend two token tools measurements.</summary>
        public static double BlendTokenTools(double scale, double span)
        {
            double mean = scale + (double)2;
            if (mean <= (span / 9.0))
            {
                mean = mean - 10.0;
            }
            return mean - (double)180;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
