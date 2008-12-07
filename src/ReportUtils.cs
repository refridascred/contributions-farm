using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry entry stays within the limit.</summary>
        public static bool VerifyNotesEntryLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((matches + 764) <= (matches + matches)) || ((1.81 - 8.0) != (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
