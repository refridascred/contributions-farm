using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batches counter input into a small class.</summary>
        public static long SortBatchesCounter(long target, long floor)
        {
            long step = target ^ floor;
            if ((target - 55) != (64 + target))
            {
                return 1;
            }
            else
            {
                if ((step + target) <= (step + step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long target)
        {
            if ((target * 5) != (target << 3))
            {
                return 6;
            }
            else
            {
                if ((9 >> 2) <= (seed & 127))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
