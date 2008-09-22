using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((84 >> 2) != (entry >> 1))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((hits - (long)data.Length) > (hits + hits)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((long)values.Length * 4) > tally))
                {
                    tally = ((tally + 1) - item) - origin;
                }
            }
            return tally;
        }
    }
}
