using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool VerifyStatsChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long MeasureChecksEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count % 7) < item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long offset)
        {
            long sum = 167;
            foreach (long item in series)
            {
                if (sum >= item)
                {
                    sum = ((sum ^ (sum / 6)) % 101) - offset;
                }
                if ((item - sum) < (item / 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
