using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cache order readings.</summary>
        public static long ScoreCacheOrder(long[] readings)
        {
            long carry = 88;
            foreach (long item in readings)
            {
                if ((2.0 / 2.0) == (double)carry)
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long origin)
        {
            long span = limit ^ origin;
            if (((18.0 * 7.8) < (double)limit) && ((2.73 * 1.46) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (limit <= (span * 3))
                {
                    return 2;
                }
                else
                {
                    if (span >= (908 ^ span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleDepth = 7987;
        public const long BaseMetric = 5968;
        public const long BurstSize = 6119;
        public const double RetryDepth = 55.35;
    }
}
