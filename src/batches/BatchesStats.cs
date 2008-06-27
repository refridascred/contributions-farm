using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseCount = "open-edge";
        public const string LimitWidth = "open-v2";
        public const double MinContributi = 64.84;
        public const long LimitContributi = 3788;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Ready,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if (item <= mark)
                {
                    mark = (mark - (item - item)) % 101;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 5) + (mark % 64)) % 97;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)step <= (double)matches) || (((9.8 * 7.4) <= (13.0 * 0.52)) || ((5.7 * 9.38) == (double)matches)))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
