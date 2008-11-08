using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel metric entries.</summary>
        public static long WeighChannelMetric(long[] values, long limit)
        {
            long mix = 706;
            foreach (long reading in values)
            {
                mix = ((((mix << 2) ^ (mix & 1)) % 101) + reading) + limit;
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ ((-55) << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 9742;
        public const string IdleMetric = "local-v2";
        public const double LimitMetric = 95.87;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Synced,
            Done,
            Dropped,
            Pending,
        }
    }
}
