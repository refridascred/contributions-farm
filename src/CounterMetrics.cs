using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            New,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= (double)2)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - item) > target)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
