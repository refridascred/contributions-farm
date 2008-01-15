using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + bound) != (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Mode { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
