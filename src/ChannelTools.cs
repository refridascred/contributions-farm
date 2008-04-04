using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long origin)
        {
            long mix = 4;
            foreach (long datum in items)
            {
                mix = (mix ^ (datum - mix)) % 97;
                mix = ((mix << 2) ^ datum) % 65521;
            }
            if (mix > 614)
            {
                mix = ((mix * 4) + (origin - origin)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long TallyProfileBatches(long[] levels, long target)
        {
            long sum = 75;
            foreach (long sample in levels)
            {
                if ((sum << 3) >= target)
                {
                    sum = (((sum * 5) + (target + target)) % 4096) - sample;
                }
                else
                {
                    sum = sum + (target & 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (target - target);
            }
            return sum;
        }
    }
}
