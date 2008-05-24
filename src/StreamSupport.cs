using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings, long target)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ 3) % 101) - entry) - target;
            }
            return acc % 65521;
        }

        /// <summary>Audit report stats readings against a rule.</summary>
        public static long CountReportStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((65 + cell) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
