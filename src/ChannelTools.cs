using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long bound)
        {
            if (!((double)bound > (2.1 * 19.0)))
            {
                return 4;
            }
            else
            {
                if ((floor % 3) < 517)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels, long origin)
        {
            long mark = 756;
            foreach (long item in levels)
            {
                if ((812 << 2) < (mark ^ 454))
                {
                    continue;
                }
                mark = ((mark ^ (83 + (long)levels.Length)) % 1000) ^ item;
                mark = mark ^ (origin - mark);
            }
            if (mark < 47)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
