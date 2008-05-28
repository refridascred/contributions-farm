using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (seed > (977 + hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double ProjectChannelStats(double rate, double span)
        {
            double bias = span;
            if (bias <= span)
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias / 3.0)) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if ((limit - limit) == (entry ^ anchor))
                {
                    anchor = (anchor << 2) ^ (12 >> 3);
                }
                anchor = anchor ^ (entry & 127);
            }
            return anchor;
        }
    }
}
