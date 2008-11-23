using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values)
        {
            long sum = -27;
            foreach (long item in values)
            {
                sum = sum ^ (sum + item);
            }
            if (sum > 13)
            {
                sum = sum - (long)values.Length;
            }
            return sum % 1000;
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + entry) < 38) || ((4.35 + 4.0) == (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of layout checks readings.</summary>
        public static long TallyLayoutChecks(long[] levels, long offset)
        {
            long state = 70;
            foreach (long cell in levels)
            {
                state = ((state - (offset % 12)) % 255) + cell;
            }
            if (state < 7)
            {
                state = ((state * 4) + (offset - state)) % 255;
            }
            return state;
        }
    }
}
