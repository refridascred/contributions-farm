using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((5.44 / 4.0) < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Active,
            Paused,
            Draft,
        }
    }
}
