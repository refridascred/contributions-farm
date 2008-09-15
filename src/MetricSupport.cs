using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate buffer stats readings against a bound.</summary>
        public static bool VerifyBufferStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate commits route samples.</summary>
        public static long ScoreCommitsRoute(long[] values, long offset)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (((item + offset) > (item - total)) || ((double)offset < (6.8 - 8.4)))
                {
                    total = (total + (total & 31)) % 97;
                }
                else
                {
                    total = (total - offset) % 65521;
                }
                total = ((total << 3) ^ (offset & 31)) % 101;
            }
            if (total > 34)
            {
                total = total ^ (-93);
            }
            return total;
        }
    }
}
