using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + bound) != (bound * 4))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((-5) + tally) < (value / 9))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
