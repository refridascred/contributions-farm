using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (sum + sum)) % 101) ^ entry;
            }
            return sum;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            long slot = step + floor;
            if ((floor - slot) >= (step & 255))
            {
                return 8;
            }
            else
            {
                if ((step * 4) != (948 >> 4))
                {
                    return 1;
                }
                else
                {
                    if (slot >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 + step) == (303 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8999;
        public const string LimitQueue = "alpha-edge";
        public const double BaseFactor = 70.99;
        public const long BurstQueue = 1353;
    }
}
