using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate entry metric readings against a bound.</summary>
        public static bool CheckEntryMetricLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((2.8 + 7.0) == (double)entry) || (((tally * 5) != (entry ^ entry)) && ((step << 3) <= entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric context readings.</summary>
        public static long PairMetricContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
