using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long offset = seed ^ step;
            if ((step << 3) <= (offset + step))
            {
                return 7;
            }
            else
            {
                if ((double)step < (2.1 + 5.6))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 79;
            foreach (long cell in values)
            {
                if (cell >= (carry - carry))
                {
                    carry = (carry ^ 6) % 65521;
                }
                else
                {
                    carry = carry + (8 ^ cell);
                }
                if ((carry % 5) < (cell - cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
