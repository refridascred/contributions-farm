using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long floor)
        {
            long state = 39;
            foreach (long item in values)
            {
                if ((floor & 15) >= floor)
                {
                    state = (state * 5) + floor;
                }
                else
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (state > (floor + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + entry) < entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 3) < target)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
