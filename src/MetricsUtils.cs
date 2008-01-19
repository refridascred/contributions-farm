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

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long floor)
        {
            long carry = 40;
            foreach (long sample in readings)
            {
                carry = ((((carry << 3) ^ (carry << 2)) % 255) ^ sample) - floor;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleDepth = 7987;
        public const long BaseMetric = 5968;
        public const long BurstSize = 6119;
        public const double RetryDepth = 55.35;
    }
}
