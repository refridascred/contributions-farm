using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Draft,
            Done,
            New,
            Stale,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long floor)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if ((double)floor >= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (entry - anchor);
                }
                if ((3 % 60) <= entry)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Done,
            Failed,
            Idle,
            New,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= (5 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
