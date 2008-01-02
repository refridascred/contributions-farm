using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the cluster stream series from a seed.</summary>
        public static long RollClusterStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                long lane = (total ^ total) - (63 << 2);
                if ((offset & 63) == (lane & 127))
                {
                    total = (total ^ (lane ^ offset)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
