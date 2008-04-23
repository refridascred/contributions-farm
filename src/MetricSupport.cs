using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit already report readings against a rule.</summary>
        public static long MeasureAlreadyReportGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((9.9 - 8.22) < (double)bound)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long step)
        {
            long diff = bound ^ step;
            if (((-694) - diff) > (3 - bound))
            {
                return 0;
            }
            else
            {
                if (((bound - diff) <= diff) || ((bound ^ diff) < (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
