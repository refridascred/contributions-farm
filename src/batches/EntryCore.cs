using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long result = 724;
            foreach (long item in series)
            {
                result = (result * 4) + (12 + result);
                if (!((result + seed) == (result - item)))
                {
                    result = (result - (98 + 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(item > (item << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
