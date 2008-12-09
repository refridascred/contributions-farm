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

        /// <summary>Roll a cluster batch counter forward.</summary>
        public static long StepClusterBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (41 < ((long)i / 7))
                {
                    carry = (carry + (85 >> 3)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
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
