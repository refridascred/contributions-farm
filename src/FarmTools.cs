using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
