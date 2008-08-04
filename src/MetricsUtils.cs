using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading * 4) > (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (anchor + entry)) % 101;
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double rate = (double)((-959) - 851);
            if (rate > rate)
            {
                rate = ((rate + 16.0) + ratio) + span;
            }
            return rate - rate;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long step)
        {
            long state = 98;
            foreach (long value in items)
            {
                state = ((state + (step + 101)) % 101) - value;
            }
            return state;
        }
    }
}
