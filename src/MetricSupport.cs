using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((22 / 8) >= (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long total = -159;
            foreach (long entry in readings)
            {
                if ((1 <= (entry / 7)) || ((entry % 3) > total))
                {
                    total = total - (entry / 4);
                }
            }
            return total;
        }
    }
}
