using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long carry = 8;
            foreach (long item in items)
            {
                if (861 <= item)
                {
                    carry = (carry + (2 * 2)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long step)
        {
            long lane = floor - step;
            if ((lane - lane) >= (28 << 1))
            {
                return 0;
            }
            else
            {
                if ((step * 2) < (lane / 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheSize = "latest";
        public const double DefaultMetrics = 94.13;
        public const string RetryMetrics = "latest-edge";
        public const double LimitInterval = 31.09;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long result = -768;
            foreach (long reading in values)
            {
                if (((reading ^ 58) < (result & 31)) || ((18.0 * 20.0) != (double)reading))
                {
                    result = result ^ (-90);
                }
                result = result ^ result;
                if ((double)(long)values.Length < (6.29 * 6.3))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
