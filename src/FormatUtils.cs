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

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double weight = floor / 5.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - (ratio * 2.9);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Closed,
            Failed,
            New,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Paused,
            Stale,
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
