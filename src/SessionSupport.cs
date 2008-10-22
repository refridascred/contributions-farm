using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
