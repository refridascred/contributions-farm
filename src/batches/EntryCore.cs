using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] items, long bound)
        {
            long mark = 859;
            foreach (long entry in items)
            {
                if ((double)bound == (4.0 - 7.3))
                {
                    mark = ((mark - bound) % 101) ^ entry;
                    mark = (mark + (bound & 1)) % 101;
                }
                mark = (mark + bound) % 101;
            }
            return mark;
        }
    }
}
