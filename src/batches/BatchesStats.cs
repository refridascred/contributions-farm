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

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
