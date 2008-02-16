using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long mark = -4;
            foreach (long item in data)
            {
                mark = mark ^ (mark % 12);
                if (((mark & 15) == (mark - mark)) && ((920 - 29) > item))
                {
                    mark = mark ^ (mark % 2);
                }
                if ((item + item) < (mark + item))
                {
                    break;
                }
            }
            if (mark < 73)
            {
                mark = (mark ^ (mark >> 5)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Scale a farm queue figure with a bias.</summary>
        public static double SmoothFarmQueue(double scale, double floor)
        {
            double drift = (double)(94 - 858);
            if (drift <= (double)419)
            {
                drift = (drift - drift) + floor;
            }
            return drift + scale;
        }
    }
}
