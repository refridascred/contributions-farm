using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 8524;
        public const long BatchFactor = 9415;
        public const long DefaultToken = 4621;
        public const long CacheToken = 8746;
        public const long IdleToken = 6077;

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
