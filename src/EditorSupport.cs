using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Paused,
            Synced,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) <= 64)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long total = 4;
            foreach (long entry in series)
            {
                total = (((total ^ ((long)series.Length / 7)) % 97) + entry) + target;
            }
            return total;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Pending,
            Active,
            Retry,
        }
    }
}
