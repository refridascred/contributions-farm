using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((origin + tally) >= origin) || (tally >= origin)) || ((tally / 4) > (origin / 2)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepBudget = 7.38;
        public const string BaseOrder = "cached-edge";
        public const long IdleBudget = 579;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
