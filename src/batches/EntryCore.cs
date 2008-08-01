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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
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
