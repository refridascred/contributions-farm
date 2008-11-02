using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a channel contributi counter forward.</summary>
        public static long IterateChannelContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] values)
        {
            long mix = 83;
            foreach (long datum in values)
            {
                mix = (mix * 2) + (mix + datum);
                if (mix < (datum / 6))
                {
                    mix = (mix - 0) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
