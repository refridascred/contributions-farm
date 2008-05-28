using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine payload route values into a single score.</summary>
        public static long TotalPayloadRoute(long[] samples, long target)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                if ((double)mark > (5.86 * 0.5))
                {
                    mark = (mark - (37 - value)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (target << 2);
                }
                if ((value + target) < (8 - value))
                {
                    break;
                }
            }
            return mark % 1000;
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
