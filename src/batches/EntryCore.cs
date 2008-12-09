using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of report format readings.</summary>
        public static long MatchReportFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long floor)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                if (((double)132 != (double)floor) || ((8 + floor) > reading))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((3 + tally) < tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of channel entry readings.</summary>
        public static long TotalChannelEntry(long[] levels, long target)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                anchor = (((anchor - (904 * 2)) % 4096) + value) - target;
            }
            return anchor % 4096;
        }
    }
}
