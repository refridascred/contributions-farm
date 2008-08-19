using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchCount = 1389;
        public const long MaxReport = 9845;
        public const string MinSize = "open-1";
        public const double IdleSize = 15.64;
        public const long StepTimeout = 5404;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (1.0 > (double)sample)
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
